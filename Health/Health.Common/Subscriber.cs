using Health.Diagnostics;
using Health.Events;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Health
{
    public sealed class Subscriber
    {
        private SubscriptionClient eventClient;
        private string eventPath;
        private string eventSubscription;

        private TraceSource source = new TraceSource("Health");

        private object locker = new object();

        private string dc;

        private string node;

        public Subscriber(string dc, string node) 
        { 
            this.dc = dc;

            this.node = node;
        }

        public void StartEvents(Action<CheckEvent> action)
        {
            using (new TraceLogicalScope(source, "StartEvents"))
            {
                try
                {
                    eventPath = String.Format("{0}/Events", dc);

                    eventSubscription = String.Format("{0}-{1}-Subscription", node, dc);

                    this.source.TraceData(TraceEventType.Verbose, 0, new object[] { "Path", eventPath });

                    string connectionString = ConfigurationManager.ConnectionStrings["Microsoft.ServiceBus.ConnectionString"].ConnectionString;

                    this.source.TraceData(TraceEventType.Verbose, 0, new object[] { "ConnectionString", connectionString });

                    this.CreateTopic(dc, eventPath);

                    this.CreateCheckEventSubscription(dc, eventPath, eventSubscription);

                    OnMessageOptions options = new OnMessageOptions()
                    {
                        AutoComplete = true, // Indicates if the message-pump should call complete on messages after the callback has completed processing.
                        MaxConcurrentCalls = 1 // Indicates the maximum number of concurrent calls to the callback the pump should initiate 
                    };

                    if(this.eventClient != null)
                        this.StopEvents();

                    this.eventClient = SubscriptionClient.CreateFromConnectionString(connectionString, eventPath, eventSubscription, ReceiveMode.PeekLock);

                    eventClient.OnMessage((BrokeredMessage message) => 
                    {
                        using(new TraceLogicalScope(source, "Receiving a message"))
                        {
                            try
                            {
                                if (message != null)
                                {
                                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(CheckEvent));

                                    CheckEvent ev = serializer.ReadObject(message.GetBody<Stream>()) as CheckEvent;

                                    action.Invoke(ev);
                                }
                            }
                            catch(Exception ex)
                            {
                                source.TraceData(TraceEventType.Error, 0, ex);

                                throw;
                            }
                        }
                    }, options);

                    source.TraceEvent(TraceEventType.Verbose, 0, "Listening for Events...");
                }
                catch (Exception ex)
                {
                    source.TraceData(TraceEventType.Error, 0, ex);

                    throw;
                }
            }
        }

        public void StopEvents()
        {
            using (new TraceLogicalScope(source, "StopEvents"))
            {
                try
                {
                    if (this.eventClient != null)
                    {
                        if (!eventClient.IsClosed)
                        {
                            this.DisableCheckEventSubscription(dc, eventPath, eventSubscription);
                        }

                        eventClient.Close();
                    }
                }
                catch (Exception ex)
                {
                    source.TraceData(TraceEventType.Error, 0, ex);

                    throw;
                }
            }
        }


        private void CreateTopic(string dc, string path)
        {
            using (new TraceLogicalScope(source, "CreateTopic"))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Microsoft.ServiceBus.ConnectionString"].ConnectionString;

                this.source.TraceData(TraceEventType.Verbose, 0, new object[] { "ConnectionString", connectionString });

                NamespaceManager ns = NamespaceManager.CreateFromConnectionString(connectionString);

                lock (this.locker)
                {
                    if (!ns.TopicExists(path))
                    {
                        source.TraceEvent(TraceEventType.Verbose, 0, "Creating topic '{0}'", path);

                        ns.CreateTopic(path);
                    }
                }
            }
        }

        private void CreateCheckEventSubscription(string dc, string path, string subscription)
        {
            using (new TraceLogicalScope(source, "CreateCheckEventSubscription"))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Microsoft.ServiceBus.ConnectionString"].ConnectionString;

                this.source.TraceData(TraceEventType.Verbose, 0, new object[] { "ConnectionString", connectionString });

                NamespaceManager ns = NamespaceManager.CreateFromConnectionString(connectionString);

                lock (this.locker)
                {
                    if (!ns.SubscriptionExists(path, subscription))
                    {
                        source.TraceEvent(TraceEventType.Verbose, 0, "Creating subscription '{0}'", subscription);

                        Filter filter = new SqlFilter(String.Format("sys.To = '{0}' and user.Type = '{1}'", dc, "Check"));

                        ns.CreateSubscription(path, subscription, filter);
                    }

                    SubscriptionDescription subscriber = ns.GetSubscription(path, subscription);

                    subscriber.Status = EntityStatus.Active;

                    ns.UpdateSubscription(subscriber);
                }
            }
        }

        private void DisableCheckEventSubscription(string dc, string path, string subscription)
        {
            using (new TraceLogicalScope(source, "CreateCheckEventSubscription"))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Microsoft.ServiceBus.ConnectionString"].ConnectionString;

                this.source.TraceData(TraceEventType.Verbose, 0, new object[] { "ConnectionString", connectionString });

                NamespaceManager ns = NamespaceManager.CreateFromConnectionString(connectionString);

                lock (this.locker)
                {
                    if (ns.SubscriptionExists(path, subscription))
                    {
                        source.TraceEvent(TraceEventType.Verbose, 0, "Disabling receive on subscription '{0}'", subscription);

                        SubscriptionDescription subscriber = ns.GetSubscription(path, subscription);

                        subscriber.Status = EntityStatus.ReceiveDisabled;

                        ns.UpdateSubscription(subscriber);
                    }
                }
            }
        }
    }
}


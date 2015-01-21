using Health.Diagnostics;
using Health.Events;
using Health.Configuration;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Health
{
    public class Publisher
    {
        Configuration.Configuration configuration = Configuration.Configuration.GetConfiguration();

        private TraceSource source = new TraceSource("Health");

        private object locker = new object();

        private string dc = String.Empty;

        public Publisher(string dc) { this.dc = dc; }

        public void Publish(CheckEvent ev)
        {
            using (new TraceLogicalScope(source, "Publish"))
            {
                try
                {
                    string path = String.Format("{0}/Events", dc);

                    this.source.TraceData(TraceEventType.Verbose, 0, new object[] { "Path", path });

                    string connectionString = configuration.ServiceBus.ConnectionString;

                    this.source.TraceData(TraceEventType.Verbose, 0, new object[] { "ConnectionString", connectionString });

                    NamespaceManager ns = NamespaceManager.CreateFromConnectionString(connectionString);

                    lock (this.locker)
                    {
                        if (!ns.TopicExists(path))
                        {
                            CreateTopic(ns, dc, path);
                        }
                    }

                    TopicClient client = TopicClient.CreateFromConnectionString(connectionString, path);

                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(ev.GetType());

                    using (Stream stream = new MemoryStream())
                    {
                        serializer.WriteObject(stream, ev);

                        stream.Seek(0, SeekOrigin.Begin);

                        BrokeredMessage message = new BrokeredMessage(stream);

                        message.To = dc;
                        message.Label = "Check";

                        message.Properties.Add("Type", "Check");
                        message.Properties.Add("Method", "PUT");

                        client.Send(message);
                    }
                }
                catch (Exception ex)
                {
                    source.TraceData(TraceEventType.Error, 0, ex);

                    throw;
                }
            }
        }

        private void CreateTopic(NamespaceManager ns, string dc, string path)
        {
            using( new TraceLogicalScope(source, "CreateTopic"))
            {
                source.TraceEvent(TraceEventType.Verbose, 0, "Creating Topic '{0}'", path);

                ns.CreateTopic(path);
            }
        }
    }
}


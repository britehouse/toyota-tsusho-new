using Health.Checks;
using Health;
using Health.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Health.Events;
using Health.Configuration;
using System.IO;
using System.Reflection;

namespace Health.Agent
{
    internal class Handler
    {
        Configuration.Configuration configuration = Configuration.Configuration.GetConfiguration();

        Publisher publisher;

        internal void Start()
        {
            Microsoft.ServiceBus.ServiceBusEnvironment.SystemConnectivity.Mode = Microsoft.ServiceBus.ConnectivityMode.Http;

            string node = configuration.Node;
            string dc = configuration.Dc;

            this.publisher = new Publisher(dc);

            TraceSource source = new TraceSource("Health.Checks");

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), dc, "Checks");

            source.TraceData(TraceEventType.Verbose, 0, "Path", path);

            foreach (PowerShellCheckItem item in PowerShellCheckFactory.Initialize(path).Values)
            {
                using (new TraceLogicalScope(source, String.Format("Processing {0}.", item.Configuration.Id)))
                {
                    if (!item.Configuration.Disabled)
                    {
                        List<string> validationErrors = new List<string>();

                        item.Check.Validate(validationErrors);

                        if (validationErrors.Count > 0)
                        {
                            foreach (string error in validationErrors)
                                source.TraceData(TraceEventType.Warning, 0, error);

                            throw new Exception("The Check contains validation errors.");
                        }

                        var ob = Observable.Create<CheckResult>((IObserver<CheckResult> observer) =>
                        {
                            return Scheduler.Default.Schedule(item.Configuration.Interval, recursive =>
                            {
                                CheckResult result = item.Check.Execute();

                                item.Check.PreviousStatus = item.Check.Status;

                                item.Check.Status = result.Status;

                                //We only push data if the status has changed

                                if (item.Check.Status != item.Check.PreviousStatus)
                                    observer.OnNext(item.Check.Execute());

                                recursive(item.Configuration.Interval);
                            });
                        });

                        ob.Subscribe((CheckResult result) =>
                        {
                            CheckEvent ev = new CheckEvent()
                            {
                                Created = DateTime.Now,
                                Id = item.Configuration.Id,
                                Message = result.Message,
                                Node = node,
                                Notes = result.Notes,
                                Source = Environment.MachineName,
                                Status = result.Status
                            };

                            publisher.Publish(ev);
                        });
                    }
                }
            }

            Console.ReadLine();
        }

        internal void Stop()
        {
        }
    }
}

using Health.Checks;
using Health.Common;
using Health.Common.Diagnostics;
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

namespace Health.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceSource source = new TraceSource("Health.Checks");

            foreach (PowerShellCheckItem item in PowerShellCheckFactory.Initialize(@"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks").Values)
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
                            Console.WriteLine("Status: {0}", result.Status);
                            Console.WriteLine("Message: {0}", result.Message);
                            Console.WriteLine("Notes: {0}", result.Notes);
                            Console.WriteLine();

                        });
                    }
                }
            }

            Console.ReadLine();
        }
    }
}

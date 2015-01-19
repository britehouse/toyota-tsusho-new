using Health.Checks;
using Health.Common;
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

            ICheck check = new PowerShellCheck()
            {
                Location = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check BizTalk Receive Location.ps1",
                Parameters = new Dictionary<string,object>()
                {
                    {"ReceiveLocationName", "Toyota.Tsusho.CRM.Services.Generic.WCF-WSHTTP"}
                }
            };

            List<string> validationErrors = new List<string>();

            check.Validate(validationErrors);

            if (validationErrors.Count > 0)
            {
                foreach (string error in validationErrors)
                    source.TraceData(TraceEventType.Warning, 0, error);

                throw new Exception("The Check contains validation errors.");
            }

            TimeSpan period = new TimeSpan(0, 0, 0, 10, 0);

            var ob = Observable.Create<CheckResult>((IObserver<CheckResult> observer) =>
            {
                return Scheduler.Default.Schedule(period, recursive => 
                {
                    CheckResult result = check.Execute();

                    check.PreviousStatus = check.Status;

                    check.Status = result.Status;

                    //We only push data if the status has changed

                    if(check.Status != check.PreviousStatus)
                        observer.OnNext(check.Execute());

                    recursive(period);
                });
            });

            ob.Subscribe((CheckResult result) =>
            {
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Message: {0}", result.Message);
                Console.WriteLine("Notes: {0}", result.Notes);
                Console.WriteLine();

            });

            Console.ReadLine();
        }
    }
}

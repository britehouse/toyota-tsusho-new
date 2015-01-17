using Health.Checks;
using Health.Common;
using System;
using System.Collections.Generic;
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

            TimeSpan period = new TimeSpan(0, 0, 0, 10, 0);

            var ob = Observable.Create<CheckResult>((IObserver<CheckResult> observer) =>
            {
                return Scheduler.Default.Schedule(period, recursive => 
                { 
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

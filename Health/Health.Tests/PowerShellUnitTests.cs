using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Health.Common;
using Health.Checks;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Disposables;

namespace Health.Tests
{
    [TestClass]
    public class PowerShellUnitTests
    {
        [TestMethod]
        public void TestPowerShellScript()
        {
            ICheck check = new PowerShellCheck()
            {
                Location = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check BizTalk Service.ps1"
            };

            List<string> validationErrors = new List<string>();

            check.Validate(validationErrors);

            Assert.AreEqual(0, validationErrors.Count);

            CheckResult result = check.Execute();

            Console.WriteLine("Message: {0}", result.Message);
            Console.WriteLine("Status: {0}", result.Status);
            Console.WriteLine("Notes: {0}", result.Notes);

            Assert.AreEqual(Status.Passed, result.Status);

        }

        [TestMethod]
        public void TestObservablePowerShellScript()
        {
            ICheck check = new PowerShellCheck()
            {
                Location = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check BizTalk Service.ps1"
            };

            List<string> validationErrors = new List<string>();

            check.Validate(validationErrors);

            Assert.AreEqual(0, validationErrors.Count);

            var ob = Observable.Create<CheckResult>(async (IObserver<CheckResult> observer) =>
            {
                observer.OnNext(await check.ExecuteAsync());

                return Disposable.Empty;
            });

            ob.Subscribe((CheckResult result) =>
            {
                Console.WriteLine("Message: {0}", result.Message);
                Console.WriteLine("Status: {0}", result.Status);
                Console.WriteLine("Notes: {0}", result.Notes);

                Assert.AreEqual(Status.Passed, result.Status);
            });

            
        }

    }
}

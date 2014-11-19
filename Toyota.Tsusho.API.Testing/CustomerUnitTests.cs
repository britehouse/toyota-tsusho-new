using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Toyota.Tsusho.API.Testing
{
    [TestClass]
    public class CustomerUnitTests
    {
        [TestMethod]
        public void TestMethodCustomerMatch()
        {
            string customer = "923465564";
            string customerA = "123FGH9077";

            string result = String.Empty;

            result = GetCustomerNumber(customer);

            Assert.AreEqual(result, "0923465564");

            result = GetCustomertNumber(customerA);

            Assert.AreEqual(result, customerA);
        }

        private string GetCustomerNumber(string customer)
        {
            string result = String.Empty;

            System.Text.RegularExpressions.Regex numbers = new System.Text.RegularExpressions.Regex("^[0-9]+$");

            if(numbers.IsMatch(customer))
                result = long.Parse(customer).ToString("0000000000");
            else
                result = customer;

            return result;
        }
    }
}

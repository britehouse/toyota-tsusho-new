using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toyota.Tsusho.API.Testing
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void OrderServiceConfirmOrder()
        {
            OrderServiceReference.ConfirmationDataContract request = new OrderServiceReference.ConfirmationDataContract()
            {
                Code = "KUN15R-TRMDYN",
                Plant = 1110,
                Units = 1,
                Produced = new DateTime(2014, 01, 04),
                Suffix = "DE",
                Color = new OrderServiceReference.ColorDataContract()
                {
                    External = "040",
                    Internal = "10I"
                },
                Category = "TOYOTA",
                Purchaser = new OrderServiceReference.PurchaserDataContract()
                {
                    Group = "TU",
                    Organization = 1100
                },
                Vendor = "TTAFVEHUSD",
                Delivery = new DateTime(2014, 04, 30),
                Order = "3KN20120801"
            };

            OrderServiceReference.OrderServiceClient client = new OrderServiceReference.OrderServiceClient();

            client.Confirm(request);
        }
    }
}

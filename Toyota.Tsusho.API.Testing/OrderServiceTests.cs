using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toyota.Tsusho.API.Testing
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void OrderServiceConfirm()
        {
            OrderServiceReference.ConfirmationCollectionDataContract request = new OrderServiceReference.ConfirmationCollectionDataContract()
            {
                new OrderServiceReference.ConfirmationDataContract()
                {
                    Code = "NCP90R-AHMRK",
                    Plant = 1110,
                    Units = 1,
                    Produced = new DateTime(2014, 01, 05),
                    Suffix = "U1",
                    Color = new OrderServiceReference.ColorDataContract()
                    {
                        External = "040",
                        Internal = "12"
                    },
                    Category = "TOYOTA",
                    Purchaser = new OrderServiceReference.PurchaserDataContract()
                    {
                        Group = "TU",
                        Organization = 1100
                    },
                    Vendor = "TTAFVEHJPY",
                    Delivery = new DateTime(2014, 05, 31),
                    Order = "3KN201405"
                }
            };

            OrderServiceReference.OrderServiceClient client = new OrderServiceReference.OrderServiceClient("OrderService.wsHttp");

            client.Confirm(request);
        }

        [TestMethod]
        public void OrderServiceRelayConfirm()
        {
            OrderServiceReference.ConfirmationCollectionDataContract request = new OrderServiceReference.ConfirmationCollectionDataContract()
            {
                new OrderServiceReference.ConfirmationDataContract()
                {
                    Code = "NCP90R-AHMRK",
                    Plant = 1110,
                    Units = 1,
                    Produced = new DateTime(2014, 01, 05),
                    Suffix = "U1",
                    Color = new OrderServiceReference.ColorDataContract()
                    {
                        External = "040",
                        Internal = "12"
                    },
                    Category = "TOYOTA",
                    Purchaser = new OrderServiceReference.PurchaserDataContract()
                    {
                        Group = "TU",
                        Organization = 1100
                    },
                    Vendor = "TTAFVEHJPY",
                    Delivery = new DateTime(2014, 05, 31),
                    Order = "3KN201405"
                }
            };

            OrderServiceReference.OrderServiceClient client = new OrderServiceReference.OrderServiceClient("OrderService.basicHttpRelay");

            client.Confirm(request);
        }
    }
}

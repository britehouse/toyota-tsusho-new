using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toyota.Tsusho.API.Testing
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ShippingInformationServiceTests
    {
        public ShippingInformationServiceTests() { }

        [TestMethod]
        public void ShippingInformationServiceUpdate()
        {
            ShippingInformationServiceReference.ShippingInformationCollectionDataContract request = new ShippingInformationServiceReference.ShippingInformationCollectionDataContract()
            {
                new ShippingInformationServiceReference.ShippingInformationDataContract()
                {
                    VehicleNumber = "0000030625",
                    Store = "0099",
                    Documented = new DateTime(2014, 3, 28),
                    Posted = new DateTime(2014, 4, 16),
                    DeliveryNote = "N0034567",
                    BillofLading = "DR306012",
                    Invoice = new ShippingInformationServiceReference.InvoiceReferenceDataContract()
                    {
                        Date = new DateTime(2014, 3, 30),
                        Number = "90679695",
                        Amount = new Decimal(560074.00)
                    },
                    Vehicles = new ShippingInformationServiceReference.VehicleReferenceCollectionDataContract()
                    {
                        new ShippingInformationServiceReference.VehicleReferenceDataContract()
                        {
                            Number = "0000030625",
                            VIN = "AHT35G9087J654321",
                            Engine = "2AR E706730",
                            Modification = ShippingInformationServiceReference.ModificationEnumeration.Create,
                            Modified = DateTime.Now

                        },
                        new ShippingInformationServiceReference.VehicleReferenceDataContract()
                        {
                            Number = "0000030626",
                            VIN = "AHT35G9087J654321",
                            Engine = "2AR E706731",
                            Modification = ShippingInformationServiceReference.ModificationEnumeration.Create,
                            Modified = DateTime.Now
                        }
                    },
                    Modification = ShippingInformationServiceReference.ModificationEnumeration.Create,
                    Modified = DateTime.Now
                }
            };

            ShippingInformationServiceReference.ShippingInformationServiceClient client = new ShippingInformationServiceReference.ShippingInformationServiceClient("ShippingInformationService.wsHttp");

            client.Update(request);
        }

        [TestMethod]
        public void ShippingInformationServiceRelayUpdate()
        {
            ShippingInformationServiceReference.ShippingInformationCollectionDataContract request = new ShippingInformationServiceReference.ShippingInformationCollectionDataContract()
            {
                new ShippingInformationServiceReference.ShippingInformationDataContract()
                {
                    VehicleNumber = "0000030625",
                    Store = "0099",
                    Documented = new DateTime(2014, 3, 28),
                    Posted = new DateTime(2014, 4, 16),
                    DeliveryNote = String.Empty,
                    BillofLading = "DR306012",
                    Invoice = new ShippingInformationServiceReference.InvoiceReferenceDataContract()
                    {
                        Date = new DateTime(2014, 3, 30),
                        Number = "90679695",
                        Amount = new Decimal(560074.00)
                    },
                    Vehicles = new ShippingInformationServiceReference.VehicleReferenceCollectionDataContract()
                    {
                        new ShippingInformationServiceReference.VehicleReferenceDataContract()
                        {
                            Number = "0000030625",
                            VIN = "AHT35G9087J654321",
                            Engine = "2AR E706730",
                            Modification = ShippingInformationServiceReference.ModificationEnumeration.Create,
                            Modified = DateTime.Now

                        },
                        new ShippingInformationServiceReference.VehicleReferenceDataContract()
                        {
                            Number = "0000030626",
                            VIN = "AHT35G9087J654321",
                            Engine = "2AR E706731",
                            Modification = ShippingInformationServiceReference.ModificationEnumeration.Create,
                            Modified = DateTime.Now
                        }
                    },
                    Modification = ShippingInformationServiceReference.ModificationEnumeration.Create,
                    Modified = DateTime.Now
                }
            };

            ShippingInformationServiceReference.ShippingInformationServiceClient client = new ShippingInformationServiceReference.ShippingInformationServiceClient("ShippingInformationService.basicHttpRelay");

            client.Update(request);
        }

    }
}

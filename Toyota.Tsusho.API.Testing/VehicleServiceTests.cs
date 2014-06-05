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
    public class VehicleServiceTests
    {
        public VehicleServiceTests() { }

        [TestMethod]
        public void VehicleServiceAllocate()
        {
            VehicleServiceReference.AllocationCollectionDataContract request = new VehicleServiceReference.AllocationCollectionDataContract()
            {
                new VehicleServiceReference.AllocationDataContract()
                {
                    Customer = "201TADDA",
                    Date = DateTime.Now,
                    DistributionChannel = "07",
                    SalesOrganisation = "1101",
                    VehicleNumber = "0000030625"
                }
            };

            VehicleServiceReference.VehicleServiceClient client = new VehicleServiceReference.VehicleServiceClient("VehicleService.wsHttp");

            client.Allocate(request);
        }

        [TestMethod]
        public void VehicleServiceRelayAllocate()
        {
            VehicleServiceReference.AllocationCollectionDataContract request = new VehicleServiceReference.AllocationCollectionDataContract()
            {
                new VehicleServiceReference.AllocationDataContract()
                {
                    Customer = "201TADDA",
                    Date = DateTime.Now,
                    DistributionChannel = "07",
                    SalesOrganisation = "1101",
                    VehicleNumber = "0000030625"
                }
            };

            VehicleServiceReference.VehicleServiceClient client = new VehicleServiceReference.VehicleServiceClient("VehicleService.basicHttpRelay");

            client.Allocate(request);
        }

        [TestMethod]
        public void VehicleServiceRegister()
        {
            VehicleServiceReference.RegistrationCollectionDataContract request = new VehicleServiceReference.RegistrationCollectionDataContract()
            {
                new VehicleServiceReference.RegistrationDataContract()
                {
                    Date = new DateTime(2014, 3, 28),
                    Number = "ATG098",
                    Type = "01",
                    VehicleNumber = "0000030625",
                    Modification = VehicleServiceReference.ModificationEnumeration.Create,
                    Modified = DateTime.Now
                }
            };

            VehicleServiceReference.VehicleServiceClient client = new VehicleServiceReference.VehicleServiceClient("VehicleService.wsHttp");

            client.Register(request);
        }

        [TestMethod]
        public void VehicleServiceRelayRegister()
        {
            VehicleServiceReference.RegistrationCollectionDataContract request = new VehicleServiceReference.RegistrationCollectionDataContract()
            {
                new VehicleServiceReference.RegistrationDataContract()
                {
                    Date = new DateTime(2014, 3, 28),
                    Number = "ATG098",
                    Type = "01",
                    VehicleNumber = "0000030625",
                    Modification = VehicleServiceReference.ModificationEnumeration.Create,
                    Modified = DateTime.Now
                }
            };

            VehicleServiceReference.VehicleServiceClient client = new VehicleServiceReference.VehicleServiceClient("VehicleService.basicHttpRelay");

            client.Register(request);
        }

    }
}

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
            VehicleServiceReference.AllocationDataContract request = new VehicleServiceReference.AllocationDataContract()
            {
                Customer = "201TADDA",
                Date = DateTime.Now,
                DistributionChannel = "07",
                SalesOrganisation = "1101",
                VehicleNumber = "0000030625"
            };

            VehicleServiceReference.VehicleServiceClient client = new VehicleServiceReference.VehicleServiceClient();

            client.Allocate(request);
        }
    }
}

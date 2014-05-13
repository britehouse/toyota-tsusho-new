using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Vehicle
{
    /// <summary>
    /// Describes a Vehicle Allocation.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/vehicle")]
    public class AllocationDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string VehicleNumber
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public string Customer
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = true)]
        public DateTime Allocated
        {
            get;
            set;
        }

        [DataMember(Order = 4, IsRequired = true)]
        public string SalesOrganisation
        {
            get;
            set;
        }

        [DataMember(Order = 5, IsRequired = true)]
        public string DistributionChannel
        {
            get;
            set;
        }

        [DataMember(Order = 6, IsRequired = true)]
        public ModificationEnumeration Modification
        {
            get;
            set;
        }

        [DataMember(Order = 7, IsRequired = true)]
        public DateTime Modified
        {
            get;
            set;
        }
    }
}

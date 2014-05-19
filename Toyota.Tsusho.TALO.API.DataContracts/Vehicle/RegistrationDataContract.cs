using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Vehicle
{
    /// <summary>
    /// Describes a Vehicle Registration.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/vehicle")]
    public class RegistrationDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string VehicleNumber
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public string Type
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = true)]
        public DateTime Date
        {
            get;
            set;
        }

        [DataMember(Order = 4, IsRequired = true)]
        public string Number
        {
            get;
            set;
        }

        [DataMember(Order = 5, IsRequired = true)]
        public ModificationEnumeration Modification
        {
            get;
            set;
        }

        [DataMember(Order = 6, IsRequired = true)]
        public DateTime Modified
        {
            get;
            set;
        }
    }
}

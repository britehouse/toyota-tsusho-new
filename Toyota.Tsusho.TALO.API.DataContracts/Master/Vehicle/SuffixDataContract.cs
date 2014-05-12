using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Master.Vehicle
{
    /// <summary>
    /// Describes a vehicle model.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/master/vehicle")]
    public class SuffixDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string Code
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public string Name
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired=false)]
        public string Grade
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = true)]
        public ModificationEnumeration Modification
        {
            get;
            set;
        }

        [DataMember(Order = 4, IsRequired = true)]
        public DateTime Modified
        {
            get;
            set;
        }
    }
}

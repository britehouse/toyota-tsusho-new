using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Customer
{
    /// <summary>
    /// Describes an Address.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/customer")]
    public class AddressDataContract
    {
        [DataMember(Order = 0, IsRequired = false)]
        public string Line1
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = false)]
        public string Line2
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired = false)]
        public string Line3
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = false)]
        public string PostalCode
        {
            get;
            set;
        }
    }
}

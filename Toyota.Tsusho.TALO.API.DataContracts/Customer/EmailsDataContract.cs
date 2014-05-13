using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Customer
{
    /// <summary>
    /// Describes a set of Email Addresses.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/customer")]
    public class EmailsDataContract
    {
        [DataMember(Order = 0, IsRequired = false)]
        public string Email
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = false)]
        public string Email2
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Customer
{
    /// <summary>
    /// Describes a set of Phone Numbers.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/customer")]
    public class PhoneNumbersDataContract
    {
        [DataMember(Order = 0, IsRequired = false)]
        public string Home
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = false)]
        public string Mobile
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired = false)]
        public string Mobile2
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = false)]
        public string Fax
        {
            get;
            set;
        }

        [DataMember(Order = 4, IsRequired = false)]
        public string Office
        {
            get;
            set;
        }
    }
}

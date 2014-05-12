using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Order
{
    /// <summary>
    /// Describes a vehicle purchaser.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/order")]
    public class PurchaserDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string Group
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public int Organization
        {
            get;
            set;
        }
    }
}

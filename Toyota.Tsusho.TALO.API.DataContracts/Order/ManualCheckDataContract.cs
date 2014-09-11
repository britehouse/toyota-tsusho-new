using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Order
{
    /// <summary>
    /// Describes an Order Creation.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/09/order")]
    public class ManualCheckDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string VehicleNumber
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public string PurchaseOrder
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired = true)]
        public DateTime Modified
        {
            get;
            set;
        }
    }
}

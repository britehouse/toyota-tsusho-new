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
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/order")]
    public class CreateNotifyDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string Number
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public string Code
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired = true)]
        public int Suffix
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = true)]
        public ColorDataContract Color
        {
            get;
            set;
        }

        [DataMember(Order = 4, IsRequired = true)]
        public string VehicleNumber
        {
            get;
            set;
        }

        [DataMember(Order = 5, IsRequired = true)]
        public string PurchaseOrder
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

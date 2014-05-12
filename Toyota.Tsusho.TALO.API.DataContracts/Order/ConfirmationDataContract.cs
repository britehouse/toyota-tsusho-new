using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Order
{
    /// <summary>
    /// Describes an Order Confirmation.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/order")]
    public class ConfirmationDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string Code
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public int Plant
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = true)]
        public int Units
        {
            get;
            set;
        }

        [DataMember(Order = 4, IsRequired = true)]
        public DateTime Produced
        {
            get;
            set;
        }

        [DataMember(Order = 5, IsRequired = true)]
        public string Suffix
        {
            get;
            set;
        }

        [DataMember(Order = 6, IsRequired = true)]
        public ColorDataContract Color
        {
            get;
            set;
        }

        [DataMember(Order = 7, IsRequired = true)]
        public string Category
        {
            get;
            set;
        }

        [DataMember(Order = 8, IsRequired = true)]
        public PurchaserDataContract Purchaser
        {
            get;
            set;
        }

        [DataMember(Order = 9, IsRequired = true)]
        public string Vendor
        {
            get;
            set;
        }

        [DataMember(Order = 10, IsRequired = true)]
        public DateTime Delivery
        {
            get;
            set;
        }

        [DataMember(Order = 11, IsRequired = true)]
        public string Order
        {
            get;
            set;
        }
    }
}

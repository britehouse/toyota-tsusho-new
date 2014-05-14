using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.ShippingInformation
{
    /// <summary>
    /// Describes Shipping Information.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/shippinginformation")]
    public class ShippingInformationDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string VehicleNumber
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public string Store
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = true)]
        public DateTime Documented
        {
            get;
            set;
        }

        [DataMember(Order = 4, IsRequired = true)]
        public DateTime Posted
        {
            get;
            set;
        }

        [DataMember(Order = 7, IsRequired = false)]
        public string DeliveryNote
        {
            get;
            set;
        }

        [DataMember(Order = 8, IsRequired = true)]
        public string BillofLading
        {
            get;
            set;
        }

        [DataMember(Order = 9, IsRequired = true)]
        public InvoiceReferenceDataContract Invoice
        {
            get;
            set;
        }


        [DataMember(Order = 10, IsRequired = true)]
        public VehicleReferenceCollectionDataContract Vehicles
        {
            get;
            set;
        }

        [DataMember(Order = 11, IsRequired = true)]
        public ModificationEnumeration Modification
        {
            get;
            set;
        }

        [DataMember(Order =12, IsRequired = true)]
        public DateTime Modified
        {
            get;
            set;
        }
    }
}

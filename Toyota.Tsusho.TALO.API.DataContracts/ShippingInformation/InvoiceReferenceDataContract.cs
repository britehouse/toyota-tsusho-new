using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.ShippingInformation
{
    /// <summary>
    /// Describes an Invoice Reference.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/shippinginformation")]
    public class InvoiceReferenceDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string Number
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public DateTime Date
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired = true)]
        public Decimal Amount
        {
            get;
            set;
        }
    }
}

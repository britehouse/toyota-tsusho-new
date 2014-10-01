using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.DataContracts
{
    [DataContract(Namespace = "http://www.ttaf.co.za/crm/api/2014/09/order")]
    public class OrderItemDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public Toyota.Tsusho.CRM.API.Invoice Invoice
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = false)]
        public ModificationEnumeration Modification
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired = false)]
        public DateTime Modified
        {
            get;
            set;
        }
    }
}

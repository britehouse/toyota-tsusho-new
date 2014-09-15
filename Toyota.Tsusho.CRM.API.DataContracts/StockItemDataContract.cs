using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.DataContracts
{
    [DataContract(Namespace = "http://www.ttaf.co.za/crm/api/2014/09/stock")]
    public class StockItemDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public Toyota.Tsusho.CRM.API.new_stock Stock
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public ModificationEnumeration Modification
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

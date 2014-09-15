using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.DataContracts
{
    [CollectionDataContract(Namespace = "http://www.ttaf.co.za/crm/api/2014/09/stock", ItemName = "Item")]
    public class StockCollectionDataContract : Collection<Toyota.Tsusho.CRM.API.DataContracts.StockItemDataContract>
    {
    }
}

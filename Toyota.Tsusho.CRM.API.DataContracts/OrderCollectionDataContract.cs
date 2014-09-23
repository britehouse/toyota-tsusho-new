using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.DataContracts
{
    [CollectionDataContract(Namespace = "http://www.ttaf.co.za/crm/api/2014/09/order", ItemName = "Item")]
    public class OrderCollectionDataContract : Collection<Toyota.Tsusho.CRM.API.DataContracts.OrderItemDataContract>
    {
    }
}

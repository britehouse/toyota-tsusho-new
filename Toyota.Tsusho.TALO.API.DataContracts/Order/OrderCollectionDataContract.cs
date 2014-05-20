using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace Toyota.Tsusho.TALO.API.DataContracts.Order
{
    [CollectionDataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/order", ItemName = "Order")]
    public class OrderCollectionDataContract : Collection<OrderDataContract>
    {
    }
}

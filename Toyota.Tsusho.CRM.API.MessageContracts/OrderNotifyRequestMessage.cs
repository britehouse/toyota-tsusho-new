using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.MessageContracts
{
    [MessageContract(IsWrapped = true)]
    public partial class OrderNotifyRequestMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/crm/api/2014/09/order", Order = 0)]
        public Toyota.Tsusho.CRM.API.DataContracts.OrderCollectionDataContract Items
        {
            get;
            set;
        }
    }
}

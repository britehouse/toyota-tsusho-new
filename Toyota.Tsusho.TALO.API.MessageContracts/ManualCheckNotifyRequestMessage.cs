using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.MessageContracts
{
    [MessageContract(IsWrapped=true)]
    public partial class ManualCheckNotifyRequestMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/talo/api/2014/09/order", Order=0)]
        public Toyota.Tsusho.TALO.API.DataContracts.Order.ManualCheckCollectionDataContract Orders
        {
            get;
            set;
        }
    }
}

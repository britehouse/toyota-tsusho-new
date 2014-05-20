using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.MessageContracts
{
    [MessageContract(IsWrapped=true)]
    public partial class OrderConfirmationRequestMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/order", Order=0)]
        public Toyota.Tsusho.TALO.API.DataContracts.Order.ConfirmationCollectionDataContract Confirmations
        {
            get;
            set;
        }
    }
}

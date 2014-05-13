using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.MessageContracts
{
    [MessageContract(IsWrapped=true)]
    public partial class CustomerCreateNotifyRequestMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/customer", Order=0)]
        public Toyota.Tsusho.TALO.API.DataContracts.Customer.CustomerDataContract Customer
        {
            get;
            set;
        }
    }
}

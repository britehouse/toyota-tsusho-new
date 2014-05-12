using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceImplementation
{
    [ServiceBehavior(Name = "OrderNotifyService",
        Namespace = "http://www.ttaf.co.za/talo/api/2014/05",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class OrderNotifyServiceBase : Toyota.Tsusho.TALO.API.ServiceContracts.IOrderNotifyService
    {
        public void CreateNotify(MessageContracts.OrderCreateNotifyRequestMessage request)
        {
            //TODO: Implement logic here to update TALO order information.
        }
    }

    public partial class OrderNotifyService : OrderNotifyServiceBase
    {

    }
}


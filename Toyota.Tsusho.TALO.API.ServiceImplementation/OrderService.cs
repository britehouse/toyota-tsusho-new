using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceImplementation
{
    [ServiceBehavior(Name = "OrderService",
        Namespace = "http://www.ttaf.co.za/talo/api/2014/05",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class OrderServiceBase : Toyota.Tsusho.TALO.API.ServiceContracts.IOrderService
    {
        public void Confirm(MessageContracts.OrderConfirmationRequestMessage request)
        {
            throw new NotImplementedException();
        }
    }

    public partial class OrderService : OrderServiceBase
    {

    }
}


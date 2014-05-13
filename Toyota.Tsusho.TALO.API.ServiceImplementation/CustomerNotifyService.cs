using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceImplementation
{
    [ServiceBehavior(Name = "CustomerNotifyService",
        Namespace = "http://www.ttaf.co.za/talo/api/2014/05",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class CustomerNotifyServiceBase : Toyota.Tsusho.TALO.API.ServiceContracts.ICustomerNotifyService
    {
        public void CreateNotify(MessageContracts.CustomerCreateNotifyRequestMessage request)
        {
            //TODO: Implement logic here to update TALO customer information.
        }
    }

    public partial class CustomerNotifyService : CustomerNotifyServiceBase
    {

    }
}


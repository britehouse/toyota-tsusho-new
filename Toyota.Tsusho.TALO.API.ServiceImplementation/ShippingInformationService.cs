using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceImplementation
{
    [ServiceBehavior(Name = "ShippingInformationService",
        Namespace = "http://www.ttaf.co.za/talo/api/2014/05",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class ShippingInformationServiceBase : Toyota.Tsusho.TALO.API.ServiceContracts.IShippingInformationService
    {
        public void Update(MessageContracts.ShippingInformationUpdateRequestMessage request)
        {
            throw new NotImplementedException();
        }
    }

    public partial class ShippingInformationService : ShippingInformationServiceBase
    {

    }
}


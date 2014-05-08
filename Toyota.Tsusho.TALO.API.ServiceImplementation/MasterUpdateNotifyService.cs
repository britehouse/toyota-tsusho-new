using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceImplementation
{
    [ServiceBehavior(Name = "MasterUpdateNotifyService",
        Namespace = "http://www.ttaf.co.za/talo/api/2014/05",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class MasterUpdateNotifyServiceBase : Toyota.Tsusho.TALO.API.ServiceContracts.IMasterUpdateNotifyService
    {
        public void Notify(MessageContracts.MasterUpdateNotifyRequestMessage request)
        {
            //TODO: Implement Logic to Create/Update Master Data in TALO
        }
    }

    public partial class MasterUpdateNotifyService : MasterUpdateNotifyServiceBase
    {

    }
}


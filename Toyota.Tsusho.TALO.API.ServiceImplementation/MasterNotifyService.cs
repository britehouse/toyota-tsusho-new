using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceImplementation
{
    [ServiceBehavior(Name = "MasterNotifyService",
        Namespace = "http://www.ttaf.co.za/talo/api/2014/05",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class MasterNotifyServiceBase : Toyota.Tsusho.TALO.API.ServiceContracts.IMasterNotifyService
    {
        public void UpdateNotify(MessageContracts.MasterUpdateNotifyRequestMessage request)
        {
            //TODO: Implement Logic to Create/Update Master Data in TALO
        }
    }

    public partial class MasterNotifyService : MasterNotifyServiceBase
    {

    }
}


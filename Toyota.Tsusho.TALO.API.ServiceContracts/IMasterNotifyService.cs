using System;
using System.Net.Security;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceContracts
{
    [ServiceContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05", SessionMode = SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None)]
    public partial interface IMasterNotifyService
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://www.ttaf.co.za/talo/api/2014/05/IMasterNotifyService/UpdateNotify", ProtectionLevel = ProtectionLevel.None)]
        void UpdateNotify(Toyota.Tsusho.TALO.API.MessageContracts.MasterUpdateNotifyRequestMessage request);
    }
}


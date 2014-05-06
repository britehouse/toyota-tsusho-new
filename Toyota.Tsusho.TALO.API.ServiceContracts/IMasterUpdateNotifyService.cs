using System;
using System.Net.Security;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceContracts
{
    [ServiceContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05", SessionMode = SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None)]
    public partial interface IMasterUpdateNotifyService
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = true, AsyncPattern = false, Action = "http://www.ttaf.co.za/talo/api/2014/05/IMasterUpdateNotifyService/Notify", ProtectionLevel = ProtectionLevel.None)]
        void Notify(Toyota.Tsusho.TALO.API.MessageContracts.MasterUpdateNotifyRequestMessage request);
    }
}


using System;
using System.Net.Security;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceContracts
{
    [ServiceContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05", SessionMode = SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None)]
    public partial interface IOrderService
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = true, AsyncPattern = false, Action = "http://www.ttaf.co.za/talo/api/2014/05/IOrderService/Confirm", ProtectionLevel = ProtectionLevel.None)]
        void Confirm(Toyota.Tsusho.TALO.API.MessageContracts.OrderConfirmationRequestMessage request);
    }
}


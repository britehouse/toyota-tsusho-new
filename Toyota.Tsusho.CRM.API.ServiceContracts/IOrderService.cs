using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Toyota.Tsusho.CRM.API.ServiceContracts
{
    [ServiceContract(Namespace = "http://www.ttaf.co.za/crm/api/2014/08", SessionMode = SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None)]
    public interface IOrderService
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://www.ttaf.co.za/crm/api/2014/09/IOrderService/Notify", ProtectionLevel = ProtectionLevel.None)]
        void Notify(Toyota.Tsusho.CRM.API.MessageContracts.OrderNotifyRequestMessage request);

    }
}

using System;
using System.Net.Security;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceContracts
{
    [ServiceContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05", SessionMode = SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None)]
    public partial interface IVehicleService
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://www.ttaf.co.za/talo/api/2014/05/IVehicleService/Allocate", ProtectionLevel = ProtectionLevel.None)]
        void Allocate(Toyota.Tsusho.TALO.API.MessageContracts.VehicleAllocateRequestMessage request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://www.ttaf.co.za/talo/api/2014/05/IVehicleService/Register", ProtectionLevel = ProtectionLevel.None)]
        void Register(Toyota.Tsusho.TALO.API.MessageContracts.VehicleRegisterRequestMessage request);
    }
}


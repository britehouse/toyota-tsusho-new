using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceImplementation
{
    [ServiceBehavior(Name = "VehicleService",
        Namespace = "http://www.ttaf.co.za/talo/api/2014/05",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class VehicleServiceBase : Toyota.Tsusho.TALO.API.ServiceContracts.IVehicleService
    {
        public void Allocate(MessageContracts.VehicleAllocateRequestMessage request)
        {
            throw new NotImplementedException();
        }

        public void Register(MessageContracts.VehicleRegisterRequestMessage request)
        {
            throw new NotImplementedException();
        }
    }

    public partial class VehicleService : VehicleServiceBase
    {

    }
}


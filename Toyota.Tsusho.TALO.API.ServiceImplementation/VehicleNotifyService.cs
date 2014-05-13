using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceImplementation
{
    [ServiceBehavior(Name = "VehicleNotifyService",
        Namespace = "http://www.ttaf.co.za/talo/api/2014/05",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class VehicleNotifyServiceBase : Toyota.Tsusho.TALO.API.ServiceContracts.IVehicleNotifyService
    {
        public void StockAgeNotify(MessageContracts.VehicleStockAgeNotifyRequestMessage request)
        {
            //TODO: Implement Logic to update TALO stock age.
        }
    }

    public partial class VehicleNotifyService : VehicleNotifyServiceBase
    {

    }
}


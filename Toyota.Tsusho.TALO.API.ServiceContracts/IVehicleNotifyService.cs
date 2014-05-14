﻿using System;
using System.Net.Security;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceContracts
{
    [ServiceContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05", SessionMode = SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None)]
    public partial interface IVehicleNotifyService
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://www.ttaf.co.za/talo/api/2014/05/IVehicleNotifyService/StockAgeNotify", ProtectionLevel = ProtectionLevel.None)]
        void StockAgeNotify(Toyota.Tsusho.TALO.API.MessageContracts.VehicleStockAgeNotifyRequestMessage request);
    }
}

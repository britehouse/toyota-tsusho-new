using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.MessageContracts
{
    [MessageContract(IsWrapped=true)]
    public partial class VehicleAllocateRequestMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/vehicle", Order=0)]
        public Toyota.Tsusho.TALO.API.DataContracts.Vehicle.AllocationDataContract Allocation
        {
            get;
            set;
        }
    }
}

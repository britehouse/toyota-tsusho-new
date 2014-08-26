using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.MessageContracts
{
    [MessageContract(IsWrapped=true)]
    public partial class MasterUpdateNotifyRequestMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/master/vehicle", Order = 0)]
        public Toyota.Tsusho.TALO.API.DataContracts.Master.Vehicle.ModelCollectionDataContract Models
        {
            get;
            set;
        }

        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/master/vehicle", Order = 1)]
        public Toyota.Tsusho.TALO.API.DataContracts.Master.Vehicle.SuffixCollectionDataContract Suffixes
        {
            get;
            set;
        }

        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/talo/api/2014/08/master/vehicle", Order = 2)]
        public Toyota.Tsusho.TALO.API.DataContracts.Master.Vehicle.ColorCollectionDataContract InternalColors
        {
            get;
            set;
        }

        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/talo/api/2014/08/master/vehicle", Order = 2)]
        public Toyota.Tsusho.TALO.API.DataContracts.Master.Vehicle.ColorCollectionDataContract ExternalColors
        {
            get;
            set;
        }
    }
}

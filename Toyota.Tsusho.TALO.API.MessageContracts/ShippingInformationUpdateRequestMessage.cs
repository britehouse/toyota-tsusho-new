using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.MessageContracts
{
    [MessageContract(IsWrapped=true)]
    public partial class ShippingInformationUpdateRequestMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/shippinginformation", Order=0)]
        public Toyota.Tsusho.TALO.API.DataContracts.ShippingInformation.ShippingInformationDataContract ShippingInformation
        {
            get;
            set;
        }
    }
}

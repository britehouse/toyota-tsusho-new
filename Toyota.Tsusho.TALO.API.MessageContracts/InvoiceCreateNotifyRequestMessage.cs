using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.MessageContracts
{
    [MessageContract(IsWrapped=true)]
    public partial class InvoiceCreateNotifyRequestMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/invoice", Order=0)]
        public Toyota.Tsusho.TALO.API.DataContracts.Invoice.InvoiceCollectionDataContract Invoices
        {
            get;
            set;
        }
    }
}

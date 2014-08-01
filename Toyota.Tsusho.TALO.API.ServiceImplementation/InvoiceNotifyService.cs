using System;
using System.ServiceModel;

namespace Toyota.Tsusho.TALO.API.ServiceImplementation
{
    [ServiceBehavior(Name = "InvoiceNotifyService",
        Namespace = "http://www.ttaf.co.za/talo/api/2014/05",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class InvoiceNotifyServiceBase : Toyota.Tsusho.TALO.API.ServiceContracts.IInvoiceNotifyService
    {
        public void CreateNotify(MessageContracts.InvoiceCreateNotifyRequestMessage request)
        {
            //TODO: Implement logic here to update TALO invoice information.
        }
    }

    public partial class InvoiceNotifyService : InvoiceNotifyServiceBase
    {

    }
}


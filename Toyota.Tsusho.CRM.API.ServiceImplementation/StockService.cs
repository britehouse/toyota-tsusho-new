using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.ServiceImplementation
{
    [ServiceBehavior(Name = "StockService",
        Namespace = "http://www.ttaf.co.za/crm/api/2014/09",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class StockServiceBase : Toyota.Tsusho.CRM.API.ServiceContracts.IStockService
    {
        public void Notify(MessageContracts.StockNotifyRequestMessage request)
        {
            throw new NotImplementedException();
        }
    }

    public partial class StockService : StockServiceBase
    {

    }
}

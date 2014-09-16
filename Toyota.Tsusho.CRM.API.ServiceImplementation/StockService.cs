using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Toyota.Tsusho.CRM.API.DataContracts;


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
            using (OrganizationServiceProxy proxy = CRMHelper.Connect())
            {
                ServiceContext context = new ServiceContext(proxy);

                foreach(StockItemDataContract item in request.Items)
                {
                    bool add = false;

                    new_stock record = (from a in context.new_stockSet
                                           where a.new_vinnumber == item.Stock.new_vinnumber
                                           select a).FirstOrDefault();

                    if(record == null)
                    {
                        add = true;

                        record = new new_stock();
                    }

                    record.new_internalvehiclenumber = item.Stock.new_internalvehiclenumber;
                    record.new_vinnumber = item.Stock.new_vinnumber;
                    record.new_enginenumber = item.Stock.new_enginenumber;
                    record.new_modelcode = item.Stock.new_modelcode;
                    record.new_plant = item.Stock.new_plant;
                    record.new_storagelocation = item.Stock.new_storagelocation;
                    record.new_stockvalue = item.Stock.new_stockvalue;
                    record.new_status = item.Stock.new_status;

                    if(add)
                        proxy.Create(record);
                    else
                        proxy.Update(record);
                }
            }
        }
    }

    public partial class StockService : StockServiceBase
    {

    }
}

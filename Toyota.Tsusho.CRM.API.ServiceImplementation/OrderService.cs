using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Toyota.Tsusho.CRM.API.DataContracts;

namespace Toyota.Tsusho.CRM.API.ServiceImplementation
{
    [ServiceBehavior(Name = "OrderService",
        Namespace = "http://www.ttaf.co.za/crm/api/2014/08",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class OrderServiceBase : Toyota.Tsusho.CRM.API.ServiceContracts.IOrderService
    {
        public void Notify(Toyota.Tsusho.CRM.API.MessageContracts.OrderNotifyRequestMessage request)
        {
            using (OrganizationServiceProxy proxy = CRMHelper.Connect())
            {
                ServiceContext context = new ServiceContext(proxy);

                foreach (OrderItemDataContract item in request.Items)
                {
                    bool add = false;

                    Invoice record = (from a in context.InvoiceSet
                                        where a.new_saporderno == item.Invoice.new_saporderno
                                        select a).FirstOrDefault();

                    if (record == null)
                    {
                        add = true;

                        record = new Invoice();
                    }

                    if (add)
                        context.AddObject(record);
                    else
                        context.UpdateObject(record);
                }

                context.SaveChanges();
            }

        }
    }

    public partial class OrderService : OrderServiceBase
    {

    }
}

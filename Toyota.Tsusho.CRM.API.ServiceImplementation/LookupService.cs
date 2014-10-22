using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.ServiceImplementation
{
    [ServiceBehavior(Name = "LookupService",
        Namespace = "http://www.ttaf.co.za/crm/api/2014/10",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class LookupServiceBase : Toyota.Tsusho.CRM.API.ServiceContracts.ILookupService, Toyota.Tsusho.CRM.API.ServiceContracts.IRESTLookupService
    {
        public MessageContracts.LookupResponseMessage Find(MessageContracts.LookupRequestMessage request)
        {
            object value;

            using (OrganizationServiceProxy proxy = CRMHelper.Connect())
            {
                ServiceContext context = new ServiceContext(proxy);

                value = (from s in context.CreateQuery(request.Lookup.Entity)
                                 where s[request.Lookup.IdField] == request.Lookup.Id
                                 select s[request.Lookup.Field]).FirstOrDefault();
            }

            return new MessageContracts.LookupResponseMessage()
            {
                Value = value as string
            };

        }

        public string Find(string entity, string idField, string id, string field)
        {
            object value;

            using (OrganizationServiceProxy proxy = CRMHelper.Connect())
            {
                ServiceContext context = new ServiceContext(proxy);

                value = (from s in context.CreateQuery(entity)
                         where s[idField] == id
                         select s[field]).FirstOrDefault();
            }

            return value as string;
        }
    }

    public partial class LookupService : LookupServiceBase
    {

    }
}

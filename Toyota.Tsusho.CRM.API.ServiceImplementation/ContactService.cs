using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.ServiceImplementation
{
    [ServiceBehavior(Name = "ContactService",
        Namespace = "http://www.ttaf.co.za/crm/api/2014/08",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class ContactServiceBase : Toyota.Tsusho.CRM.API.ServiceContracts.IContactService
    {
        public void Publish(Toyota.Tsusho.CRM.API.MessageContracts.ContactPublishRequestMessage request)
        {
            throw new NotImplementedException();
        }
    }

    public partial class ContactService : ContactServiceBase
    {

    }
}

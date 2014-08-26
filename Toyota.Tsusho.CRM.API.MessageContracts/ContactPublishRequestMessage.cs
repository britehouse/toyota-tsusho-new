using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.MessageContracts
{
    [MessageContract(IsWrapped = true)]
    public partial class ContactPublishRequestMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/crm/api/2014/08/contact", Order = 0)]
        public Toyota.Tsusho.CRM.API.DataContracts.ModificationEnumeration Modification
        {
            get;
            set; 
        }

        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/crm/api/2014/08/contact", Order = 1)]
        public Toyota.Tsusho.CRM.API.Contact Contact
        {
            get;
            set;
        }
    }
}

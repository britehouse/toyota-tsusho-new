using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.MessageContracts
{
    [MessageContract(IsWrapped = true)]
    public partial class LookupRequestMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/crm/api/2014/10/lookup", Order = 0)]
        public Toyota.Tsusho.CRM.API.DataContracts.LookupDataContract Lookup
        {
            get;
            set; 
        }
    }
}

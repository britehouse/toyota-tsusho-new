using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.MessageContracts
{
    [MessageContract(IsWrapped = true)]
    public partial class LookupResponseMessage
    {
        [MessageBodyMember(Namespace = "http://www.ttaf.co.za/crm/api/2014/10/lookup", Order = 0)]
        public string Value
        {
            get;
            set; 
        }
    }
}

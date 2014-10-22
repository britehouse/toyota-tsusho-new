using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.CRM.API.DataContracts
{
    [DataContract(Namespace = "http://www.ttaf.co.za/crm/api/2014/10/lookup")]
    public class LookupDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string Entity
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public string IdField
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired = true)]
        public string Id
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = true)]
        public string Field
        {
            get;
            set;
        }
    }
}

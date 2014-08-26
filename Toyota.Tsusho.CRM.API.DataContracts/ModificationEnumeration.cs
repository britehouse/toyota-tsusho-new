using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Toyota.Tsusho.CRM.API.DataContracts
{
    [DataContract(Namespace = "http://www.ttaf.co.za/crm/api/2014/08")]
    public enum ModificationEnumeration
    {
        [EnumMember]
        Create,
        [EnumMember]
        Update
    }
}

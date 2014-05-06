using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Toyota.Tsusho.TALO.API.DataContracts.Master
{
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/master")]
    public enum ModificationEnumeration
    {
        [EnumMember]
        Create,
        [EnumMember]
        Update
    }
}

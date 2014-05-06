using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Master
{
    /// <summary>
    /// Describes a color.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/master")]
    public class CodeNameDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string Code
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public string Name
        {
            get;
            set;
        }
    }
}

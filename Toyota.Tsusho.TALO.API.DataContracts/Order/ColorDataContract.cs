using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Order
{
    /// <summary>
    /// Describes a vehicle color.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/order")]
    public class ColorDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string Internal
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public string External
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Health.Events
{
    [DataContract]
    public class CheckEvent
    {
        [DataMember(IsRequired = true)]
        public String Id { get; set; }

        [DataMember(IsRequired = true)]
        public Status Status { get; set; }

        [DataMember(IsRequired = true)]
        public string Node { get; set; }

        [DataMember(IsRequired = true)]
        public string Source { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Notes { get; set; }

        [DataMember(IsRequired = true)]
        public DateTime Created { get; set; }
    }
}

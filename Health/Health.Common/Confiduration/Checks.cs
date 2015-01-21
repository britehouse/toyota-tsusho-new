using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Health.Configuration
{
    public sealed class Checks : List<Check> { }

    [DataContract]
    public sealed class Check
    {
        [DataMember(IsRequired= true)]
        public string Id { get; set; }

        [DataMember()]
        public string Description { get; set; }

        [DataMember(IsRequired= true)]
        public string Script { get; set; }

        [DataMember()]
        public Dictionary<string, object> Parameters { get; set; }

        [DataMember(IsRequired= true)]
        public TimeSpan Interval { get; set; }

        [DataMember()]
        public bool Disabled { get; set; }
    }
}

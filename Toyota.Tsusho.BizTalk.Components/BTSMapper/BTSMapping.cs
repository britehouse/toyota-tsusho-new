using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toyota.Tsusho.BizTalk.Components
{
    [XmlRoot(Namespace=String.Empty)]
    public class BTSMapping
    {
        [XmlArray(
    }
 
    public class Mapping
    {
        [XmlElement(IsNullable=false, Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public From From { get; set; }

        [XmlElement(IsNullable = false, Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public From To { get; set; }
    }

    public class From
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("value")]
        public string Value { get; set; }
    }

    public class To
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}

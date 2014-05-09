using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.ServiceModel
{
    public enum HostReplace
    {
        None,
        MachineName,
        FQDN,
        IPAddress
    }

    public class EndpointAddressBehaviorExtensionElement : BehaviorExtensionElement
    {
        [ConfigurationProperty("address", IsRequired=true)]
        public string Address
        {
            get { return (string) base["address"]; }
            set { base["address"] = value; }
        }

        [ConfigurationProperty("hostReplace", DefaultValue= HostReplace.None)]
        public HostReplace HostReplace
        {
            get { return (HostReplace)base["hostReplace"]; }
            set { base["hostReplace"] = value; }
        }

        public override Type BehaviorType
        {
            get
            {
                return typeof(EndpointAddressBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new EndpointAddressBehavior(this);
        }
    }
}

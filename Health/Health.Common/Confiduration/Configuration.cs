using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.Configuration
{
    public class Configuration : System.Configuration.ConfigurationSection
    {
        public static Configuration GetConfiguration()
        {
            Configuration configuration =
                ConfigurationManager
                .GetSection("Health")
                as Configuration;

            return configuration;
        }

        [ConfigurationProperty("dc", IsRequired = true)]
        public string Dc
        {
            get { return this["dc"] as string; }
            set { this["dc"] = value; }
        }

        [ConfigurationProperty("node", IsRequired = true)]
        public string Node
        {
            get { return this["node"] as string; }
            set { this["node"] = value; }
        }

        [ConfigurationProperty("ServiceBus", IsRequired=true)]
        public ServiceBusElement ServiceBus
        {
            get { return this["ServiceBus"] as ServiceBusElement; }
            set { this["ServiceBus"] = value; }
        }
    }

    public class ServiceBusElement : ConfigurationElement
    {
        [ConfigurationProperty("connectionString", IsRequired=true)]
        public string ConnectionString
        {
            get { return this["connectionString"] as string; }
            set { this["connectonString"] = value; }
        }
    }
}

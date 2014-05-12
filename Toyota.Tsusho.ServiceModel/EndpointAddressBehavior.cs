using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.ServiceModel
{
    public class EndpointAddressBehavior : Attribute, IWsdlExportExtension, IEndpointBehavior, IServiceBehavior
    {
        private readonly EndpointAddressBehaviorExtensionElement configuration;

        public EndpointAddressBehavior(EndpointAddressBehaviorExtensionElement configuration)
        {
            this.configuration = configuration;
        }

        public void AddBindingParameters(ServiceEndpoint endpoint,
            BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint,
            ClientRuntime clientRuntime)
        {
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint,
            EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }

        public void AddBindingParameters(ServiceDescription serviceDescription,
            ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints,
            BindingParameterCollection bindingParameters)
        {
            // If we are added as service behavior, add us to all the endpoints
            foreach (ServiceEndpoint endpoint in endpoints)
            {
                if (!endpoint.Behaviors.Contains(typeof(EndpointAddressBehavior)))
                    endpoint.Behaviors.Add(this);
            }
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription,
            ServiceHostBase serviceHostBase)
        {
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }

        public void ExportContract(WsdlExporter exporter,
            WsdlContractConversionContext context)
        {
        }

        public void ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context)
        {
            UriBuilder builder = new UriBuilder(this.configuration.Address);

            builder.Scheme = context.Endpoint.Binding.Scheme;

            switch (this.configuration.HostReplace)
            {
                case HostReplace.MachineName:
                    {
                        builder.Host = Environment.MachineName  ;
                        break;
                    }

                case HostReplace.FQDN:
                    {
                        string domain = IPGlobalProperties.GetIPGlobalProperties().DomainName;

                        if(!string.IsNullOrWhiteSpace(domain))
                            builder.Host = string.Format("{0}.{1}", Environment.MachineName, IPGlobalProperties.GetIPGlobalProperties().DomainName);
                        else
                            builder.Host = Environment.MachineName;

                        break;
                    }

                case HostReplace.IPAddress:
                    {
                        builder.Host = GetIPAddress();
                        break;
                    }
            }

            context.Endpoint.Address = new EndpointAddress(builder.Uri.ToString());
        }

        private string GetIPAddress()
        {
            return Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toyota.Tsusho.CRM.API.Plugins
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class ContactServiceClient : System.ServiceModel.ClientBase<Toyota.Tsusho.CRM.API.Plugins.IContactService>, Toyota.Tsusho.CRM.API.Plugins.IContactService
    {

        public ContactServiceClient()
        {
        }

        public ContactServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public ContactServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ContactServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ContactServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void Publish(Toyota.Tsusho.CRM.API.MessageContracts.ContactPublishRequestMessage request)
        {
            base.Channel.Publish(request);
        }

    }
}

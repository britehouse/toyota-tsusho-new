using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toyota.Tsusho.CRM.API;
using Toyota.Tsusho.CRM.API.MessageContracts;

namespace CRMUnitTests
{
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ttaf.co.za/crm/api/2014/08", ConfigurationName="ContactServiceReference.IContactService")]
    public interface IContactService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ttaf.co.za/crm/api/2014/08/IContactService/Publish", ReplyAction="http://www.ttaf.co.za/crm/api/2014/08/IContactService/PublishResponse")]
        void Publish(ContactPublishRequestMessage request);        
    }
            
    public interface IContactServiceChannel : IContactService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class ContactServiceClient : System.ServiceModel.ClientBase<IContactService>, IContactService {
        
        public ContactServiceClient() {
        }
        
        public ContactServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void Publish(ContactPublishRequestMessage request) {
            base.Channel.Publish(request);
        }
    }
}

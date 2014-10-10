using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toyota.Tsusho.CRM.API.Plugins
{
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.ttaf.co.za/crm/api/2014/08", ConfigurationName = "Toyota.Tsusho.CRM.Services.Generic.OnRamp")]
    public interface IContactService
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.ttaf.co.za/crm/api/2014/08/IContactService/Publish")]
        void Publish(Toyota.Tsusho.CRM.API.MessageContracts.ContactPublishRequestMessage request);
    }
}

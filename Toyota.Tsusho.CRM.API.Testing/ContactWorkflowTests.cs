using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Activities;
using System.Collections.Generic;
using Microsoft.Crm.Sdk;
using Microsoft.Xrm.Sdk;

namespace Toyota.Tsusho.CRM.API.Testing
{
    [TestClass]
    public class ContactWorkflowTests
    {
        [TestMethod]
        public void TestContactWorkflow()                  
        {
            IDictionary<string, Entity> inputEntities = new Dictionary<string, Entity>();

            inputEntities.Add("primaryEntity", new Entity("contact"));
            
            IDictionary<string, Entity> createdEntities = new Dictionary<string, Entity>();

            IDictionary<string, object> inputs = new Dictionary<string, object>();

            inputs.Add("InputEntities", inputEntities);
            inputs.Add("CreatedEntities", createdEntities);

            Activity workflowActivity = System.Activities.XamlIntegration.ActivityXamlServices.Load(@"C:\Projects\Toyota.Tsusho\Toyota.Tsusho.CRM.API.Workflows\ContactWorkflow.xaml");

            System.Activities.WorkflowInvoker invoker = new System.Activities.WorkflowInvoker(workflowActivity);

            invoker.Invoke(inputs);
        }

        [TestMethod]
        public void TestRESTWorkflow()
        {
            IDictionary<string, Entity> inputEntities = new Dictionary<string, Entity>();

            inputEntities.Add("primaryEntity", new Entity("contact"));

            IDictionary<string, Entity> createdEntities = new Dictionary<string, Entity>();

            IDictionary<string, object> inputs = new Dictionary<string, object>();

            inputs.Add("InputEntities", inputEntities);
            inputs.Add("CreatedEntities", createdEntities);

            Activity workflowActivity = System.Activities.XamlIntegration.ActivityXamlServices.Load(@"C:\Projects\Toyota.Tsusho\Toyota.Tsusho.CRM.API.Workflows\RESTCall.xaml");

            System.Activities.WorkflowInvoker invoker = new System.Activities.WorkflowInvoker(workflowActivity);

            invoker.Invoke(inputs);
        }
    }
}

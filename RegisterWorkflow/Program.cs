using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toyota.Tsusho.CRM.API;

namespace RegisterWorkflow
{
    class Program
    {
        [System.Runtime.Serialization.DataContractAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "6.1.0000.0532")]
        public enum WorkflowMode
        {

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Background = 0,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Realtime = 1,
        }

        [System.Runtime.Serialization.DataContractAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "6.1.0000.0532")]
        public enum WorkflowType
        {

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Definition = 1,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Activation = 2,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Template = 3,
        }

        [System.Runtime.Serialization.DataContractAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "6.1.0000.0532")]
        public enum WorkflowCategory
        {

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Workflow = 0,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Dialog = 1,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            BusinessRule = 2,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Action = 3,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            BusinessProcessFlow = 4,
        }

        [System.Runtime.Serialization.DataContractAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "6.1.0000.0532")]
        public enum WorkflowScope
        {

            [System.Runtime.Serialization.EnumMemberAttribute()]
            User = 1,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            BusinessUnit = 2,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            ParentChildBusinessUnits = 3,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Organization = 4,
        }

        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("PublishContactWorkflow.xaml", Encoding.UTF8))
                {
                    using (OrganizationServiceProxy proxy = CRMHelper.Connect())
                    {
                        ServiceContext context = new ServiceContext(proxy);

                        //<snippetCreateAWorkflow1>
                        // Create an asynchronous workflow.
                        // The workflow should execute after a new opportunity is created.
                        Workflow workflow = new Workflow()
                        {
                            // These properties map to the New Process form settings in the web application.

                            Name = "Publish Contact to BizTalk Server",

                            Type = new OptionSetValue((int)WorkflowType.Definition),

                            Category = new OptionSetValue((int)WorkflowCategory.Workflow),

                            PrimaryEntity = Contact.EntityLogicalName,

                            Mode = new OptionSetValue((int)WorkflowMode.Background),

                            OnDemand = false,

                            Subprocess = false,

                            Scope = new OptionSetValue((int)WorkflowScope.User),

                            TriggerOnCreate = true,

                            AsyncAutoDelete = true,

                            Xaml = reader.ReadToEnd(),

                            // Other properties not in the web forms.
                            LanguageCode = 1033,  // U.S. English                        
                        };

                        proxy.Create(workflow);

                        Console.WriteLine("Created Workflow: " + workflow.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

        }
    }
}

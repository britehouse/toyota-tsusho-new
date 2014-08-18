using System;
using System.CodeDom;
using System.Diagnostics;
using Microsoft.Crm.Services.Utility;

namespace CrmSvcUtilExtensions
{
    /// <summary>
    /// Create an implementation of ICustomizeCodeDomService if you want to manipulate the
    /// code dom after ICodeGenerationService has run.
    /// </summary>
    /// By default crmsvcutil does not add a DataMember attribute to the Properties of generated
    /// classes, rendering them useless to BizTalk Server. This code will iterate through all Namespaces, Types,
    /// Members, Properties that are public and add the Attribute.
    public sealed class WCFCustomizationService : ICustomizeCodeDomService
    {
        private CodeAttributeDeclaration datamember = new CodeAttributeDeclaration("System.Runtime.Serialization.DataMemberAttribute");

        public void CustomizeCodeDom(CodeCompileUnit codeUnit, IServiceProvider services)
        {

            Trace.TraceInformation("Entering ICustomizeCodeDomService.CustomizeCodeDom");

            foreach (CodeNamespace ns in codeUnit.Namespaces)
            {
                Trace.TraceInformation("Iterating Namespace {0}", ns.Name);

                foreach (CodeTypeDeclaration type in ns.Types)
                {
                    Trace.TraceInformation("Inspecting Type {0}", type.Name);

                    //For the moment we only want to interogate Class Members and add the DataMember attribute...
                    if (type.IsClass)
                    {
                        foreach (CodeTypeMember member in type.Members)
                        {
                            Trace.TraceInformation("Inspecting Member {0}", member.Name);

                            if (member is CodeMemberProperty)
                            {
                                CodeMemberProperty property = member as CodeMemberProperty;

                                //We only do Public Properties
                                if (property.Attributes.HasFlag(MemberAttributes.Public))
                                {
                                    Trace.TraceInformation("Adding Attribute {0}", datamember.Name);

                                    //We can currently only replace single line getters, so we do not do this where the getter is 
                                    //more than 1 line

                                    if (property.HasGet)
                                    {
                                        if (property.GetStatements.Count == 1)
                                        {
                                            //Add the DataMember Attribute
                                            property.CustomAttributes.Add(datamember);

                                            //We now need to find IEnumerable Types and Replace them with a List...

                                            if (property.Type.BaseType.StartsWith("System.Collections.Generic.IEnumerable"))
                                            {
                                                CodeTypeReference[] typeArguments = new CodeTypeReference[property.Type.TypeArguments.Count];

                                                property.Type.TypeArguments.CopyTo(typeArguments, 0);

                                                property.Type = new CodeTypeReference("System.Collections.Generic.List", typeArguments);

                                                Trace.TraceInformation("Replacing Getter...");

                                                CodeMethodReturnStatement original = property.GetStatements[0] as CodeMethodReturnStatement;

                                                if (original != null && property.Type != null)
                                                {
                                                    CodeObjectCreateExpression creator = new CodeObjectCreateExpression(property.Type, new CodeExpression[] { original.Expression });

                                                    property.GetStatements.Add(new CodeMethodReturnStatement(creator));

                                                    property.GetStatements.RemoveAt(0);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    Trace.TraceInformation("Exiting ICustomizeCodeDomService.CustomizeCodeDom");
                }
            }
        }
    }
}
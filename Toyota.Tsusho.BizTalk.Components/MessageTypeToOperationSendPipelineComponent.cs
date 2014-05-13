using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Message.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.BizTalk.Components
{
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_AssemblingSerializer)]
    [Guid("BA5FC95C-389A-42C4-A8CA-D6C757025DF5")]
    public class MessageTypeToOperationSendPipelineComponent : IBaseComponent, IAssemblerComponent
    {
        private string NS = "http://schemas.microsoft.com/BizTalk/2003/system-properties";

        private Microsoft.BizTalk.Component.XmlAsmComp assembler = new Microsoft.BizTalk.Component.XmlAsmComp();

        public MessageTypeToOperationSendPipelineComponent() { }

        #region IBaseComponent Members

        public string Description
        {
            get
            {
                return "Transfers the MessageType context property to the operation context property.";
            }
        }

        public string Name
        {
            get
            {
                return "MessageTypeToOperationSendPipelineComponent";
            }
        }

        public string Version
        {
            get
            {
                return "1.0";
            }
        }

        #endregion

        #region IAssemblerComponent Members

        public void AddDocument(IPipelineContext pc, IBaseMessage pInMsg)
        {
            assembler.AddDocument(pc, pInMsg);

            string type = String.Empty;

            try
            {
                type = pInMsg.Context.Read("MessageType", NS) as string;
            }
            catch
            {
                type = String.Empty;
            }

            if (!string.IsNullOrWhiteSpace(type))
            {
                pInMsg.Context.Write("Operation", NS, type);
                pInMsg.Context.Promote("Operation", NS, type);
            }
        }

        public IBaseMessage Assemble(IPipelineContext pContext)
        {
            return assembler.Assemble(pContext);
        }

        #endregion
    }
}

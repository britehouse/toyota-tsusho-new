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
    [ComponentCategory(CategoryTypes.CATID_DisassemblingParser)]
    [Guid("51477570-B013-4A8D-88A6-91501DD7B0E0")]
    public class MessageTypeToOperationReceivePipelineComponent : IBaseComponent, IDisassemblerComponent
    {
        private string NS = "http://schemas.microsoft.com/BizTalk/2003/system-properties";

        Microsoft.BizTalk.Component.XmlDasmComp disassembler = new Microsoft.BizTalk.Component.XmlDasmComp();

        public MessageTypeToOperationReceivePipelineComponent() { }

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
                return "MessageTypeToOperationReceivePipelineComponent";
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

        #region IDisassemblerComponent Members

        public void Disassemble(IPipelineContext pc, IBaseMessage pInMsg)
        {
            disassembler.Disassemble(pc, pInMsg);

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

        public IBaseMessage GetNext(IPipelineContext pContext)
        {
            return disassembler.GetNext(pContext);
        }

        #endregion
    }
}

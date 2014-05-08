using Microsoft.BizTalk.Component.Interop;
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
    public class BTSMapperPipelineComponent : IBaseComponent, IProbeMessage
    {
        public BTSMapperPipelineComponent() { }

        #region IBaseComponent Members

        public string Description
        {
            get
            {
                return "BizTalk Mapper Component that maps context properties";
            }
        }

        public string Name
        {
            get
            {
                return "BizTalk Mapper Component that maps context properties";
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

        public bool Probe(IPipelineContext pContext, Microsoft.BizTalk.Message.Interop.IBaseMessage pInMsg)
        {
            return false;
        }
    }
}

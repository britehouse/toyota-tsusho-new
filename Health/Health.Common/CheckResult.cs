using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.Common
{
    public enum Status
    {
        Unknown,
        Passed,
        Failed
    }

    public class CheckResult
    {
        public Status Status
        {
           get;
           set;
        }

        public string Message
        {
            get;
            set;
        }

        public string Notes
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.Common
{
    public interface ICheck
    {
        string Location
        {
            get;
            set;
        }

        void Validate(List<string> errors);

        Task<CheckResult> ExecuteAsync();

        CheckResult Execute();
    }
}

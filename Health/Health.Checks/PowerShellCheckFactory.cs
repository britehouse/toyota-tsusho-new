using Health.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Health.Checks
{
    public class PowerShellCheckItem
    {
        public Health.Confiduration.Check Configuration
        {
            get;
            set;
        }

        public PowerShellCheck Check
        {
            get;
            set;
        }
    }
    public static class PowerShellCheckFactory
    {
        private static TraceSource source = new TraceSource("Health.Checks");

        public static Dictionary<string, PowerShellCheckItem> Initialize(string folder)
        {
            using (new TraceLogicalScope(source, "Initialize"))
            {
                Dictionary<string, PowerShellCheckItem> checks = new Dictionary<string, PowerShellCheckItem>();

                if (string.IsNullOrWhiteSpace(folder))
                    throw new ArgumentException("Empty folder.", "folder");

                if (!Directory.Exists(folder))
                    throw new ArgumentException(String.Format("Folder '{0}' does not exist.", folder), "folder");

                foreach(string file in Directory.GetFiles(folder, "*.json"))
                {
                    using (new TraceLogicalScope(source, string.Format("Processing {0}", file)))
                    {
                        try
                        {
                        
                            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Health.Confiduration.Checks));

                            using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                            {
                                Health.Confiduration.Checks items = serializer.ReadObject(stream) as Health.Confiduration.Checks;

                                foreach(Health.Confiduration.Check item in items)
                                {
                                    using (new TraceLogicalScope(source, string.Format("Processing {0}", item.Id)))
                                    {
                                        if (checks.ContainsKey(item.Id))
                                            throw new Exception(String.Format("Duplicate entry '{0}'.", item.Id));

                                        PowerShellCheckItem check = new PowerShellCheckItem()
                                        {
                                            Check = new PowerShellCheck()
                                            {
                                                Id = item.Id,
                                                Location = Path.Combine(folder, item.Script),
                                                Parameters = item.Parameters
                                            },
                                            Configuration = item
                                        };

                                        checks.Add(item.Id, check);
                                    }
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            throw new Exception(String.Format("Error processing check file '{0}'.", file), ex);
                        }
                    }
                }

                return checks;
            }
        }
    }
}

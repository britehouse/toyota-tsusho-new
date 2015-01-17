using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;

using Health.Common;
using System.IO;
using System.Management.Automation.Runspaces;

namespace Health.Checks
{
    public sealed class PowerShellCheck : ICheck
    {
        public string Location
        {
            get;
            set;
        }

        public Dictionary<string, object> Parameters
        {
            get;
            set;
        }

        public Status PreviousStatus
        {
            get;
            set;
        }

        public Status Status
        {
            get;
            set;
        }

        public void Validate(List<string> errors)
        {
            if (string.IsNullOrWhiteSpace(this.Location))
                errors.Add("The Script location was not specified.");

            if (!File.Exists(this.Location))
                errors.Add(string.Format("The Script could not be found at '@'.", this.Location));
        }

        public CheckResult Execute()
        {
                CheckResult result = new CheckResult()
                {
                    Status = Status.Passed
                };

                using (PowerShell instance = PowerShell.Create())
                {
                    using (StreamReader reader = new StreamReader(new FileStream(this.Location, FileMode.Open, FileAccess.Read)))
                        instance.AddScript(reader.ReadToEnd());

                    try
                    {
                        if (this.Parameters != null)
                        {
                            foreach (string key in this.Parameters.Keys)
                                instance.AddParameter(key, this.Parameters[key]);
                        }

                        Collection<PSObject> results = instance.Invoke();
                    }
                    catch (Exception ex)
                    {
                        result.Message = ex.Message;

                        result.Notes = ex.ToString();

                        result.Status = Status.Failed;
                    }
                    finally
                    {
                        string streams = LogStreams(instance.Streams);

                        if (!String.IsNullOrWhiteSpace(streams))
                            result.Notes = streams;
                    }

                    return result;
                }
        }

        public async Task<CheckResult> ExecuteAsync()
        {
            return await Task.Run<CheckResult>(() =>
            {
                return this.Execute();
            });
        }

        string LogStreams(PSDataStreams streams)
        {
            List<String> entries = new List<string>();

            foreach (DebugRecord record in streams.Debug)
                entries.Add(String.Format("Debug: {0}", record));

            foreach (ErrorRecord record in streams.Error)
                entries.Add(String.Format("Error: {0}", record));

            foreach (VerboseRecord record in streams.Verbose)
                entries.Add(String.Format("Verbose: {0}", record));

            foreach (WarningRecord record in streams.Warning)
                entries.Add(String.Format("Warning: {0}", record));

            StringBuilder notes = new StringBuilder();

            foreach (string entry in entries)
                notes.AppendLine(entry);

            return notes.ToString();
        }
    }
}

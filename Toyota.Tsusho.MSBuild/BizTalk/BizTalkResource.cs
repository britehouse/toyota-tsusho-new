using Microsoft.BizTalk.ApplicationDeployment;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Toyota.Tsusho.MSBuild.BizTalk
{
    /// <summary>
    /// Custom Task for manipulating a BizTalk Resource.
    /// </summary>
    public class BizTalkResource : Microsoft.Build.Utilities.Task
    {
        /// <summary>
        /// The BizTalk Application in which the resource is located.
        /// </summary>
        [Required]
        public string Application
        {
            get;
            set;
        }

        /// <summary>
        /// The Name of the BizTalk Management Database.
        /// </summary>
        public string Database
        {
            get;
            set;
        }

        /// <summary>
        /// The Name of the Sql Server where the BizTalk Management Database is located.
        /// </summary>
        public string DatabaseServer
        {
            get;
            set;
        }

        /// <summary>
        /// The Name of the BizTalk Resource
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The Type of the BizTalk Resource.
        /// </summary>
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// The Source file location of the BizTalk Resource.
        /// </summary>
        public string Source
        {
            get;
            set;
        }

        /// <summary>
        /// The destination file location where the BizTalk Resource should be installed.
        /// </summary>
        public string Destination
        {
            get;
            set;
        }

        /// <summary>
        /// Flag specifying if the resource should be added to the Global Assembly
        /// Cache when the resource is added.
        /// </summary>
        public bool UpdateGac
        {
            get;
            set;
        }

        /// <summary>
        /// Flag specifying if the resource should be added to the Global Assembly
        /// Cache when the resource is added.
        /// </summary>
        public bool Gacutil
        {
            get;
            set;
        }

        /// <summary>
        /// Flag specifying if the resource should be added to the Global Assembly
        /// Cache when the resource is imported.
        /// </summary>
        public bool UpdateGacOnImport
        {
            get;
            set;
        }

        /// <summary>
        /// The Target Environment if the Resource Type is a BizTalk Binding File.
        /// </summary>
        public string Environment
        {
            get;
            set;
        }

        /// <summary>
        /// The action that the Task should perform. Possible values include the following:
        /// Update: Updates a BizTalk Resource.
        /// </summary>
        [Required]
        public string TaskAction
        {
            get;
            set;
        }

        public override bool Execute()
        {
            switch (this.TaskAction)
            {
                case "Update":
                    {
                        this.Update();

                        return true;
                    }

                default:
                    {
                        Log.LogError("Unrecognized Task Action {0}", this.TaskAction);

                        return false;
                    }
            }
        }

        private Group ConnectGroup()
        {
            Group group = new Group();

            if (String.IsNullOrWhiteSpace(this.DatabaseServer))
                this.DatabaseServer = System.Environment.MachineName;

            if (String.IsNullOrWhiteSpace(this.Database))
                this.Database = "BizTalkMgmtDb";

            group.DBServer = this.DatabaseServer;
            group.DBName = this.Database;

            group.OperationComplete = true;

            return group;
        }

        private void Update()
        {
            using (Group group = this.ConnectGroup())
            {
                try
                {
                    Microsoft.BizTalk.ApplicationDeployment.Application application = group.Applications[this.Application];
                    
                    application.UILevel = 1;
                    application.Log += new Microsoft.BizTalk.Log.LogEventHandler(BizTalk_Log);

                    Log.LogMessage("Inspecting Application {0}...", this.Application);

                    Log.LogMessage("Adding {0}", this.Name);

                    Resource resource = new Resource(application, this.Type, this.Name);

                    resource.Properties = new Dictionary<string, object>();

                    resource.Properties["SourceLocation"] = this.Source;

                    if (!string.IsNullOrWhiteSpace(this.Destination))
                        resource.Properties["DestinationLocation"] = this.Destination;

                    switch (this.Type)
                    {
                        case "System.BizTalk:BizTalkBinding":
                            {
                                if (resource.Properties.ContainsKey("TargetEnvironment"))
                                    resource.Properties.Remove("TargetEnvironment");

                                resource.Properties.Add("TargetEnvironment", this.Environment);

                                break;
                            }

                        default:
                            {
                                resource.Properties.Add("UpdateGac", this.UpdateGac);
                                resource.Properties.Add("Gacutil", this.Gacutil);
                                resource.Properties.Add("UpdateGacOnImport", this.UpdateGacOnImport);

                                break;
                            }
                    }

                   application.AddResource(this.Type, this.Name, resource.Properties, true);
                }
                catch
                {
                    group.Abort();

                    throw;
                }
            }
        }

        void BizTalk_Log(object sender, Microsoft.BizTalk.Log.LogEventArgs e)
        {
            switch (e.LogEntry.Type)
            {
                case Microsoft.BizTalk.Log.LogEntryType.Error:
                    {
                        Log.LogError(e.LogEntry.Message);
                        break;
                    }

                case Microsoft.BizTalk.Log.LogEntryType.Information:
                case Microsoft.BizTalk.Log.LogEntryType.None:
                case Microsoft.BizTalk.Log.LogEntryType.Verbose:
                    {
                        Log.LogMessage(e.LogEntry.Message);
                        break;
                    }

                case Microsoft.BizTalk.Log.LogEntryType.Warning:
                    {
                        Log.LogWarning(e.LogEntry.Message);
                        break;
                    }
            }
        }
    }
}

using Microsoft.BizTalk.ExplorerOM;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.BizTalk.ApplicationDeployment;
using System.Reflection;


namespace Toyota.Tsusho.MSBuild.BizTalk
{
    /// <summary>
    /// Custom Task for retrieving BizTalk Application information.
    /// </summary>
    public class BizTalkApplication : Microsoft.Build.Utilities.Task
    {
        /// <summary>
        /// The Name of the BizTalk Application for which information needs to be retrieved.
        /// </summary>
        public string Application
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the BizTalk Management Database. If not specified the default name of BizTalkMgmtDb is used.
        /// </summary>
        public string Database
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the Sql Server where the BizTalk Management Database is located.
        /// </summary>
        public string DatabaseServer
        {
            get;
            set;
        }

        /// <summary>
        /// Output property containing the result of the task after execution.
        /// </summary>
        [Output]
        public ITaskItem[] Output
        {
            get;
            set;
        }

        /// <summary>
        /// Output property containing the number of results of the task after execution.
        /// </summary>
        [Output]
        public int OutputCount
        {
            get;
            set;
        }

        /// <summary>
        /// The action that the task must perform.
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
                case "GetReferencings":
                    {
                        Queue<string> queue = new Queue<string>();

                        IBtsCatalogExplorer2 explorer = ConnectExplorer();

                        GetReferencingList(explorer, this.Application, queue);

                        List<TaskItem> list = new List<TaskItem>();

                        foreach (string application in queue)
                        {
                            TaskItem item = new TaskItem();

                            item.itemSpec = application;
                            item.SetMetadata("DatabaseServer", this.DatabaseServer);
                            item.SetMetadata("Database", this.Database);

                            list.Add(item);
                        }

                        this.Output = list.ToArray();
                        this.OutputCount = list.Count;

                        this.Log.LogMessage("Setting OutputCount to {0}", this.OutputCount);
                        
                        break;
                    }

                case "GetReferences":
                    {
                        Queue<string> queue = new Queue<string>();

                        IBtsCatalogExplorer2 explorer = ConnectExplorer();

                        GetReferencesList(explorer, this.Application, queue);

                        List<TaskItem> list = new List<TaskItem>();

                        foreach (string application in queue)
                        {
                            TaskItem item = new TaskItem();

                            item.itemSpec = application;
                            item.SetMetadata("DatabaseServer", this.DatabaseServer);
                            item.SetMetadata("Database", this.Database);

                            list.Add(item);
                        }

                        this.Output = list.ToArray();
                        this.OutputCount = list.Count;

                        this.Log.LogMessage("Setting OutputCount to {0}", this.OutputCount);

                        break;
                    }

                case "GetResources":
                    {
                        Queue<ITaskItem> queue = this.GetResourcesList(this.Application);

                        this.Output = queue.ToArray();
                        this.OutputCount = queue.Count;

                        return true;
                    }

                case "GetList":
                    {
                        Queue<ITaskItem> queue = new Queue<ITaskItem>();

                        this.GetList(queue);

                        this.Output = queue.ToArray();
                        this.OutputCount = queue.Count;

                        return true;
                    }

                default:
                    {
                        Log.LogError("Unrecognized Task Action {0}", this.TaskAction);

                        return false;
                    }
            }

            return true;
        }

        private  IBtsCatalogExplorer2 ConnectExplorer()
        {
            SqlConnectionStringBuilder builder = null;

            if (!String.IsNullOrWhiteSpace(this.DatabaseServer))
            {
                builder = new SqlConnectionStringBuilder();

                builder.IntegratedSecurity = true;

                builder.DataSource = this.DatabaseServer;
            }

            if (!String.IsNullOrWhiteSpace(this.Database))
            {
                if (builder == null)
                {
                    builder = new SqlConnectionStringBuilder();

                    builder.IntegratedSecurity = true;

                    builder.DataSource = Environment.MachineName;

                    this.DatabaseServer = builder.DataSource;
                }

                builder.InitialCatalog = this.Database;
            }

            if (builder == null)
            {
                builder = new SqlConnectionStringBuilder();

                builder.IntegratedSecurity = true;

                builder.DataSource = Environment.MachineName;
                builder.InitialCatalog = "BizTalkMgmtDb";

                this.DatabaseServer = builder.DataSource;
                this.Database = builder.InitialCatalog;
            }

            IBtsCatalogExplorer2 explorer = new BtsCatalogExplorer();

            explorer.ConnectionString = builder.ConnectionString;

            return explorer;
        }

        private Group ConnectGroup()
        {
            Group group = new Group();

            if (String.IsNullOrWhiteSpace(this.DatabaseServer))
                this.DatabaseServer = Environment.MachineName;

            if (String.IsNullOrWhiteSpace(this.Database))
                this.Database = "BizTalkMgmtDb";

            group.DBServer = this.DatabaseServer;
            group.DBName = this.Database;

            return group;
        }

        private void GetReferencingList(IBtsCatalogExplorer2 explorer, string name, Queue<string> list)
        {
            this.Log.LogMessage("Examining {0}...", name);

            foreach (IBizTalkApplication application in explorer.Applications)
            {
                if (!application.IsSystem)
                {
                    foreach (IBizTalkApplication reference in application.References)
                    {
                        if (!reference.IsSystem)
                        {
                            if (reference.Name == name)
                            {
                                GetReferencingList(explorer, application.Name, list);

                                if (!list.Contains(application.Name))
                                {
                                    list.Enqueue(application.Name);

                                    this.Log.LogMessage("Adding {0}", application.Name);
                                }
                            }
                        }
                    }
                }  
            }
        }

        private void GetReferencesList(IBtsCatalogExplorer2 explorer, string name, Queue<string> list)
        {
            this.Log.LogMessage("Examining {0}...", name);

            foreach (IBizTalkApplication application in explorer.Applications)
            {
                if (application.Name == name)
                {
                    foreach (IBizTalkApplication reference in application.References)
                    {
                        if (!reference.IsSystem)
                        {
                            GetReferencesList(explorer, reference.Name, list);

                            if (!list.Contains(reference.Name))
                            {
                                list.Enqueue(reference.Name);

                                this.Log.LogMessage("Adding {0}", reference.Name);
                            }
                        }
                    }
                }
            }
        }

        private Queue<ITaskItem> GetResourcesList(string name)
        {
            Queue<ITaskItem> list = new Queue<ITaskItem>();

            using (Group group = this.ConnectGroup())
            {
                foreach (Microsoft.BizTalk.ApplicationDeployment.Application application in group.Applications)
                {
                    if (application.Name == name)
                    {
                        Log.LogMessage("Inspecting Application {0}...", name);

                        foreach (Resource resource in application.ResourceCollection)
                        {
                            bool dynamic = false;

                            Log.LogMessage("Inspecting Resource {0}", resource.Luid);

                            ITaskItem task = new TaskItem();

                            task.ItemSpec = resource.Luid;

                            Log.LogMessage("Name: {0}", resource.Luid);
                            task.SetMetadata("Identity", resource.Luid);

                            Log.LogMessage("Type: {0}", resource.ResourceType);
                            task.SetMetadata("Type", resource.ResourceType);

                            foreach (string key in resource.Properties.Keys)
                            {
                                Log.LogMessage("{0}: {1}", key, resource.Properties[key]);
                                task.SetMetadata(key, resource.Properties[key].ToString());

                                if (key == "IsDynamic")
                                    dynamic = (bool)resource.Properties[key];
                            }

                            if(!dynamic)
                                list.Enqueue(task);
                        }
                    }
                }
            }

            return OrderResourceList(list);
        }

        private Queue<ITaskItem> OrderResourceList(Queue<ITaskItem> list)
        {
            List<ITaskItem> temp = new List<ITaskItem>(list);

            for (int i = 0; i < temp.Count; i++)
            {
                ITaskItem task = temp[i];

                if (task.GetMetadata("Type") == "System.BizTalk:BizTalkAssembly")
                {
                    int index = 0;

                    foreach (ITaskItem item in list)
                    {
                        if (item.GetMetadata("Type") == "System.BizTalk:BizTalkAssembly")
                        {
                            Assembly assembly = Assembly.LoadFrom(item.GetMetadata("SourceLocation"));

                            AssemblyName[] references = assembly.GetReferencedAssemblies();

                            bool referenced = false;

                            foreach (AssemblyName assemblyName in references)
                            {
                                if (assemblyName.FullName == task.ItemSpec)
                                {
                                    referenced = true;

                                    break;
                                }
                            }

                            if (referenced)
                            {
                                temp.RemoveAt(i);

                                temp.Insert(index, task);
                            }
                        }

                        index++;
                    }
                }
            }

            return new Queue<ITaskItem>(temp);
        }

        private void GetList(Queue<ITaskItem> list)
        {
            using (Group group = this.ConnectGroup())
            {
                foreach (Microsoft.BizTalk.ApplicationDeployment.Application application in group.Applications)
                {
                    TaskItem task = new TaskItem();

                    task.ItemSpec = application.Name;

                    task.SetMetadata("Identity", application.Name);

                    if (!string.IsNullOrWhiteSpace(application.Description))
                        task.SetMetadata("Description", application.Description);

                    task.SetMetadata("IsDefault", application.IsDefault.ToString());
                    task.SetMetadata("IsSystem", application.IsSystem.ToString());

                    //task.SetMetadata("Status", application.Status.ToString());

                    list.Enqueue(task);
                }
            }
        }

    }
}
    
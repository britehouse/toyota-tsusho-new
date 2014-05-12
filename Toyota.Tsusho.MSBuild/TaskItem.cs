using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Tsusho.MSBuild
{
    public class TaskItem : ITaskItem
    {
        private Dictionary<string, string> metaData = new Dictionary<string,string>();

        public string itemSpec;

        public System.Collections.IDictionary CloneCustomMetadata()
        {
            return this.metaData;
        }

        public void CopyMetadataTo(ITaskItem destinationItem)
        {
            foreach(string key in this.metaData.Keys)
                destinationItem.SetMetadata(key, this.metaData[key]);
        }

        public string GetMetadata(string metadataName)
        {
            return this.metaData[metadataName];
        }

        public string ItemSpec
        {
            get
            {
                return this.itemSpec;
            }
            set
            {
                this.itemSpec = value;
            }
        }

        public int MetadataCount
        {
            get { return this.metaData.Count; }
        }

        public System.Collections.ICollection MetadataNames
        {
            get { return this.metaData.Keys; }
        }

        public void RemoveMetadata(string metadataName)
        {
            this.metaData.Remove(metadataName);
        }

        public void SetMetadata(string metadataName, string metadataValue)
        {
            if (this.metaData.ContainsKey(metadataName))
                this.metaData[metadataName] = metadataValue;
            else
                this.metaData.Add(metadataName, metadataValue);
        }

        public override string ToString()
        {
            return this.ItemSpec;
        }
    }
}

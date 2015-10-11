using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SyncthingApi.Data
{
    [DataContract]
    public class VersionData
    {
        [DataMember(Name = "arch", IsRequired = true, EmitDefaultValue = false)]
        private string arch;

        public string Architecture
        {
            get { return this.arch; }
        }

        [DataMember(Name = "longVersion", IsRequired = false, EmitDefaultValue = false)]
        private string longVersion;

        public string LongVersion
        {
            get { return this.longVersion; }
        }

        [DataMember(Name = "os", IsRequired = false, EmitDefaultValue = false)]
        private string os;

        public string OperativeSystem
        {
            get { return this.os; }
        }

        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        private string version;

        public string Version
        {
            get { return this.version; }
        }
    }
}

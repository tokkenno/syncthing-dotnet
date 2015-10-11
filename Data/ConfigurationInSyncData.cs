using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SyncthingApi.Data
{
    [DataContract]
    public class ConfigurationInSyncData
    {
        [DataMember(Name = "configInSync", IsRequired = true, EmitDefaultValue = true)]
        private Boolean configInSync;

        public Boolean ConfigInSync
        {
            get { return this.configInSync; }
        }
    }
}

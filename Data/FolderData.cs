using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Syncthing.API.Data
{
    [DataContract]
    public class FolderData
    {
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        private string id;

        public string ID
        {
            get { return this.id; }
        }

        [DataMember(Name = "path", IsRequired = false, EmitDefaultValue = false)]
        private string path;

        public string Path
        {
            get { return this.path; }
        }
        
        [DataMember(Name = "devices", IsRequired = false, EmitDefaultValue = false)]
        private List<DeviceData> devices;

        public List<DeviceData> Devices
        {
            get { return this.devices; }
        }
        
        [DataMember(Name = "readOnly", IsRequired = false)]
        private Boolean readOnly;

        public Boolean ReadOnly
        {
            get { return this.readOnly; }
        }

        [DataMember(Name = "rescanIntervalS", IsRequired = false)]
        private int rescanIntervalS;

        public int RescanIntervalS
        {
            get { return this.rescanIntervalS; }
        }

        [DataMember(Name = "ignorePerms", IsRequired = false)]
        private Boolean ignorePerms;

        public Boolean IgnorePerms
        {
            get { return this.ignorePerms; }
        }

        [DataMember(Name = "autoNormalize", IsRequired = false)]
        private Boolean autoNormalize;

        public Boolean AutoNormalize
        {
            get { return this.autoNormalize; }
        }

        [DataMember(Name = "minDiskFreePct", IsRequired = false)]
        private int minDiskFreePct;

        public int MinDiskFreePct
        {
            get { return this.minDiskFreePct; }
        }

        [DataMember(Name = "copiers", IsRequired = false)]
        private int copiers;

        public int Copiers
        {
            get { return this.copiers; }
        }

        [DataMember(Name = "pullers", IsRequired = false)]
        private int pullers;

        public int Pullers
        {
            get { return this.pullers; }
        }

        [DataMember(Name = "hashers", IsRequired = false)]
        private int hashers;

        public int Hashers
        {
            get { return this.hashers; }
        }

        [DataMember(Name = "order", IsRequired = false, EmitDefaultValue = false)]
        private string order;

        public string Order // FIXME: Enumeration?
        {
            get { return this.order; }
        }

        [DataMember(Name = "ignoreDelete", IsRequired = false)]
        private Boolean ignoreDelete;

        public Boolean IgnoreDelete
        {
            get { return this.ignoreDelete; }
        }

        // TODO: versioning, invalid
    }
}

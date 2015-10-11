using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SyncthingApi.Data
{
    [DataContract]
    public class StatusData
    {
        [DataMember(Name = "alloc", IsRequired = true, EmitDefaultValue = false)]
        private UInt64 alloc;

        public UInt64 Alloc
        {
            get { return this.alloc; }
        }

        [DataMember(Name = "cpuPercent", IsRequired = true, EmitDefaultValue = false)]
        private float cpuPercent;

        public float CPUPercent
        {
            get { return this.cpuPercent; }
        }

        [DataMember(Name = "extAnnounceOK", IsRequired = true, EmitDefaultValue = false)]
        private Dictionary<String, Boolean> extAnnounceOK;

        public Dictionary<String, Boolean> ExtAnnounceOK
        {
            get { return this.extAnnounceOK; }
        }

        [DataMember(Name = "goroutines", IsRequired = true, EmitDefaultValue = false)]
        private int goroutines;

        public int Threads
        {
            get { return this.goroutines; }
        }

        [DataMember(Name = "myID", IsRequired = true, EmitDefaultValue = false)]
        private string myID;

        public string ClientID
        {
            get { return this.myID; }
        }

        [DataMember(Name = "pathSeparator", IsRequired = true, EmitDefaultValue = false)]
        private string pathSeparator;

        public string PathSeparator
        {
            get { return this.pathSeparator; }
        }

        [DataMember(Name = "sys", IsRequired = true, EmitDefaultValue = false)]
        private UInt64 sys;

        public UInt64 RAM // TODO: ?
        {
            get { return this.sys; }
        }

        [DataMember(Name = "tilde", IsRequired = true, EmitDefaultValue = false)]
        private string tilde;

        public string Tilde // TODO: User dir?
        {
            get { return this.tilde; }
        }

        [DataMember(Name = "uptime", IsRequired = true, EmitDefaultValue = false)]
        private UInt64 uptime;

        public UInt64 Uptime // TODO: User dir?
        {
            get { return this.uptime; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Syncthing.API.Data
{
    [DataContract]
    public class ConnectionData
    {
        [DataMember(Name = "address", IsRequired = false, EmitDefaultValue = false)]
        private string address;

        public string Address
        {
            get { return this.address; }
        }

        [DataMember(Name = "at", IsRequired = false, EmitDefaultValue = false)]
        private string at;

        public string At
        {
            get { return this.at; }
        }

        [DataMember(Name = "clientVersion", IsRequired = false, EmitDefaultValue = false)]
        private string clientVersion;

        public string ClientVersion
        {
            get { return this.clientVersion; }
        }

        [DataMember(Name = "inBytesTotal", IsRequired = false, EmitDefaultValue = false)]
        private UInt64 inBytesTotal;

        public UInt64 InBytesTotal
        {
            get { return this.inBytesTotal; }
        }

        [DataMember(Name = "outBytesTotal", IsRequired = false, EmitDefaultValue = false)]
        private UInt64 outBytesTotal;

        public UInt64 OutBytesTotal
        {
            get { return this.outBytesTotal; }
        }
    }
}

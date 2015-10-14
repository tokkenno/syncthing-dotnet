using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Syncthing.API.Data
{
    [DataContract]
    public class DeviceData
    {
        [DataMember(Name = "deviceID", IsRequired = true, EmitDefaultValue = true)]
        private string deviceID;

        public string ID
        {
            get { return this.deviceID; }
        }

        [DataMember(Name = "name", IsRequired = false, EmitDefaultValue = false)]
        private string name;

        public string Name
        {
            get { return this.name; }
        }

        [DataMember(Name = "addresses", IsRequired = false, EmitDefaultValue = false)]
        private List<String> addresses;

        public List<String> Addresses
        {
            get { return this.addresses; }
        }

        [DataMember(Name = "compression", IsRequired = false, EmitDefaultValue = false)]
        private string compression;

        public string Compresion // FIXME: Enumeration?
        {
            get { return this.compression; }
        }

        [DataMember(Name = "certName", IsRequired = false, EmitDefaultValue = false)]
        private string certName;

        public string CertName
        {
            get { return this.certName; }
        }

        [DataMember(Name = "introducer", IsRequired = false)]
        private Boolean introducer;

        public Boolean Introducer
        {
            get { return this.introducer; }
        }
    }
}

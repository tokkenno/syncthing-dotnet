using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Syncthing.API.Data
{
    [DataContract]
    public class GuiConfigurationData
    {
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        private Boolean enabled;

        public Boolean Enabled
        {
            get { return this.enabled; }
        }

        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        private string address;

        public string Address
        {
            get { return this.address; }
        }

        [DataMember(Name = "user", IsRequired = false, EmitDefaultValue = false)]
        private string user;

        public string User
        {
            get { return this.user; }
        }

        [DataMember(Name = "password", IsRequired = false, EmitDefaultValue = false)]
        private string password;

        public string Password
        {
            get { return this.password; }
        }

        [DataMember(Name = "useTLS", IsRequired = false)]
        private Boolean useTLS;

        public Boolean UseTLS
        {
            get { return this.useTLS; }
        }

        [DataMember(Name = "apiKey", IsRequired = false, EmitDefaultValue = false)]
        private String apiKey;

        public String ApiKey
        {
            get { return this.apiKey; }
        }
    }
}

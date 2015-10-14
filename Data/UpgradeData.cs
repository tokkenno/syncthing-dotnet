using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Syncthing.API.Data
{
    [DataContract]
    public class UpgradeData
    {
        [DataMember(Name = "latest", IsRequired = false, EmitDefaultValue = false)]
        private string latest;

        public string Latest
        {
            get { return this.latest; }
        }

        [DataMember(Name = "newer", IsRequired = true)]
        private Boolean newer;

        public Boolean Newer
        {
            get { return this.newer; }
        }

        [DataMember(Name = "running", IsRequired = true, EmitDefaultValue = false)]
        private string running;

        public string Running
        {
            get { return this.running; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SyncthingApi.Data
{
    [DataContract]
    public class ErrorData
    {
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = false)]
        private string error;

        public string Message
        {
            get { return this.error; }
        }

        [DataMember(Name = "time", IsRequired = true, EmitDefaultValue = false)]
        private string time;

        public string Time
        {
            get { return this.time; }
        }
    }
}

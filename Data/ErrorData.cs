using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Syncthing.API.Utils;

namespace Syncthing.API.Data
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

        public DateTime Time
        {
            get { return JavascriptFormatHelper.ConvertTime(time); }
        }
    }
}

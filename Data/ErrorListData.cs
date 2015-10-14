using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Syncthing.API.Data
{
    [DataContract]
    class ErrorListData
    {
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = false)]
        private List<ErrorData> errors;

        public List<ErrorData> Errors
        {
            get { return this.errors; }
        }
    }
}

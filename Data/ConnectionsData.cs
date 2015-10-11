using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SyncthingApi.Data
{
    [DataContract]
    public class ConnectionsData
    {
        [DataMember(Name = "connections", IsRequired = true, EmitDefaultValue = true)]
        private Dictionary<String, ConnectionData> connections;

        public Dictionary<String, ConnectionData> Connections
        {
            get { return this.connections; }
        }

        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        private ConnectionData total;

        /// <summary>
        /// Get the list of connections to the system
        /// </summary>
        /// <returns>List of connections as ID, ConnectionData pairs.</returns>
        public ConnectionData Total
        {
            get { return this.total; }
        }
    }
}

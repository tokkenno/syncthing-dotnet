using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncthing.API.Data
{
    public class DiscoveryData
    {
        private string id;
        private List<DiscoveryConnectionData> connections;

        public DiscoveryData(String id, List<DiscoveryConnectionData> connections)
        {
            this.id = id;
            this.connections = connections;
        }

        public String ID
        {
            get { return this.id; }
        }

        public List<DiscoveryConnectionData> Connections
        {
            get { return this.connections; }
        }
    }
}

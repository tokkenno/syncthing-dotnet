using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncthing.API
{
    public class EventAPIClient : Net.RestClient
    {
        public EventAPIClient(String url, String apikey) : base(url, apikey)
        {
        }
    }
}

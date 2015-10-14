using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Syncthing.API.Net
{
    public abstract class RestClient
    {
        private RestSharp.RestClient client;
        private string apikey;

        public RestClient(String url, String apikey)
        {
            this.client = new RestSharp.RestClient(url);
            this.apikey = apikey;
        }

        protected IRestResponse GET(String path)
        {
            var request = new RestRequest("rest" + path, Method.GET);
            request.AddHeader("X-API-Key", this.apikey);
            return client.Execute(request);
        }

        protected T Deserialize<T>(String content)
        {
            try
            {
                DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
                settings.UseSimpleDictionaryFormat = true;
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T), settings);
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content));
                return (T)ser.ReadObject(ms);
            }
            catch (Exception e)
            {
                throw new ApiException("Serialization error. " + e.Message);
            }
        }
    }
}

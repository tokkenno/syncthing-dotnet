using RestSharp;
using SyncthingApi.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SyncthingApi
{
    public class RestClient
    {
        private RestSharp.RestClient client;
        private string apikey;

        public RestClient(String url, String apikey)
        {
            this.client = new RestSharp.RestClient(url);
            this.apikey = apikey;
        }

        public Configuration GetSystemConfig()
        {
            var request = new RestRequest("rest/system/config", Method.GET);
            request.AddHeader("X-API-Key", this.apikey);

            IRestResponse res = client.Execute(request);

            Console.WriteLine(res.ErrorMessage);

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<Configuration>(res.Content);
        }

        private T Deserialize<T>(String content)
        {
            try {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
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

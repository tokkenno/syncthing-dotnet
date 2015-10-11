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

        private IRestResponse GET(String path)
        {
            var request = new RestRequest("rest" + path, Method.GET);
            request.AddHeader("X-API-Key", this.apikey);
            return client.Execute(request);
        }

        public ConfigurationData GetSystemConfig()
        {
            IRestResponse res = this.GET("/system/config");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<ConfigurationData>(res.Content);
        }

        public ConfigurationInSyncData GetSystemConfigInSync()
        {
            IRestResponse res = this.GET("/system/config/insync");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<ConfigurationInSyncData>(res.Content);
        }
        
        public ConnectionsData GetSystemConnections()
        {
            IRestResponse res = this.GET("/system/connections");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<ConnectionsData>(res.Content);
        }

        private T Deserialize<T>(String content)
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

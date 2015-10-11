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

        /// <summary>
        /// GET /rest/system/config
        /// </summary>
        /// <returns>System configuration data</returns>
        public ConfigurationData GetSystemConfig()
        {
            IRestResponse res = this.GET("/system/config");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<ConfigurationData>(res.Content);
        }

        /// <summary>
        /// GET /rest/system/config/insync
        /// </summary>
        /// <returns></returns>
        public ConfigurationInSyncData GetSystemConfigInSync()
        {
            IRestResponse res = this.GET("/system/config/insync");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<ConfigurationInSyncData>(res.Content);
        }

        /// <summary>
        /// GET /rest/system/connections
        /// </summary>
        /// <returns>Connections info</returns>
        public ConnectionsData GetSystemConnections()
        {
            IRestResponse res = this.GET("/system/connections");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<ConnectionsData>(res.Content);
        }

        /// <summary>
        /// GET /rest/system/discovery
        /// </summary>
        /// <returns>List of discovery connections</returns>
        public List<DiscoveryData> GetSystemDiscovery()
        {
            IRestResponse res = this.GET("/system/discovery");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            Dictionary < String, List < DiscoveryConnectionData >> desdata = 
                this.Deserialize<Dictionary<String, List<DiscoveryConnectionData>>>(res.Content);

            List<DiscoveryData> toret = new List<DiscoveryData>();
            foreach (KeyValuePair<String, List<DiscoveryConnectionData>> elem in desdata)
            {
                toret.Add(new DiscoveryData(elem.Key, elem.Value));
            }

            return toret;
        }

        /// <summary>
        /// GET /rest/system/error
        /// </summary>
        /// <returns>List of errors</returns>
        public List<ErrorData> GetSystemError()
        {
            IRestResponse res = this.GET("/system/error");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<ErrorListData>(res.Content).Errors;
        }

        /// <summary>
        /// GET /rest/system/ping
        /// </summary>
        /// <returns>True if server respond</returns>
        public Boolean Ping()
        {
            IRestResponse res = this.GET("/system/error");

            if (res.ErrorException != null)
            {
                return false;
            }

            return res.Content.Contains("pong");
        }

        /// <summary>
        /// GET /rest/system/status
        /// </summary>
        /// <returns>Status info</returns>
        public StatusData GetSystemStatus()
        {
            IRestResponse res = this.GET("/system/status");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<StatusData>(res.Content);
        }

        /// <summary>
        /// GET /rest/system/upgrade
        /// </summary>
        /// <returns>Upgrade info</returns>
        public UpgradeData GetSystemUpgrade()
        {
            IRestResponse res = this.GET("/system/upgrade");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<UpgradeData>(res.Content);
        }

        /// <summary>
        /// GET /rest/system/version
        /// </summary>
        /// <returns>Version info</returns>
        public VersionData GetSystemVersion()
        {
            IRestResponse res = this.GET("/system/version");

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return this.Deserialize<VersionData>(res.Content);
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

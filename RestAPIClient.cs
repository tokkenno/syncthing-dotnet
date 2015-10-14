using RestSharp;
using Syncthing.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syncthing.API
{
    public class APIRestClient : Syncthing.API.Net.RestClient
    {

        public APIRestClient(String url, String apikey) : base(url, apikey)
        {
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

        /// <summary>
        /// GET /rest/db/browse
        /// </summary>
        /// <returns>Version info</returns>
        public DirectoryData GetDbBrowse(String folder)
        {
            IRestResponse res = this.GET("/db/browse?folder=" + folder);

            if (res.ErrorException != null)
            {
                throw new ApiException(res.ErrorMessage);
            }

            return DirectoryData.DeserializeJson(res.Content);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SyncthingApi.Beans
{
    [DataContract]
    public class ConfigurationOptions
    {
        [DataMember(Name = "listenAddress", IsRequired = false, EmitDefaultValue = false)]
        private List<String> listenAddress;

        public List<String> ListenAddress
        {
            get { return this.listenAddress; }
        }

        [DataMember(Name = "globalAnnounceServers", IsRequired = false, EmitDefaultValue = false)]
        private List<String> globalAnnounceServers;

        public List<String> GlobalAnnounceServers
        {
            get { return this.globalAnnounceServers; }
        }

        [DataMember(Name = "globalAnnounceEnabled", IsRequired = false)]
        private Boolean globalAnnounceEnabled;

        public Boolean GlobalAnnounce
        {
            get { return this.globalAnnounceEnabled; }
        }

        [DataMember(Name = "localAnnounceEnabled", IsRequired = false)]
        private Boolean localAnnounceEnabled;

        public Boolean LocalAnnounceEnabled
        {
            get { return this.localAnnounceEnabled; }
        }

        [DataMember(Name = "localAnnouncePort", IsRequired = false, EmitDefaultValue = false)]
        private UInt16 localAnnouncePort;

        public UInt16 LocalAnnouncePort
        {
            get { return this.localAnnouncePort; }
        }

        [DataMember(Name = "localAnnounceMCAddre", IsRequired = false, EmitDefaultValue = false)]
        private string localAnnounceMCAddre;

        public string LocalAnnounceMCAddre
        {
            get { return this.localAnnounceMCAddre; }
        }

        [DataMember(Name = "maxSendKbps", IsRequired = false, EmitDefaultValue = true)]
        private int maxSendKbps;

        public int MaxSendKbps
        {
            get { return this.maxSendKbps; }
        }

        [DataMember(Name = "maxRecvKbps", IsRequired = false, EmitDefaultValue = true)]
        private int maxRecvKbps;

        public int MaxRecvKbps
        {
            get { return this.maxRecvKbps; }
        }

        [DataMember(Name = "reconnectionIntervalS", IsRequired = false, EmitDefaultValue = true)]
        private int reconnectionIntervalS;

        public int ReconnectionIntervalS
        {
            get { return this.reconnectionIntervalS; }
        }

        [DataMember(Name = "startBrowser", IsRequired = false)]
        private Boolean startBrowser;

        public Boolean StartBrowser
        {
            get { return this.startBrowser; }
        }

        [DataMember(Name = "upnpEnabled", IsRequired = false)]
        private Boolean upnpEnabled;

        public Boolean UPnPEnabled
        {
            get { return this.upnpEnabled; }
        }

        [DataMember(Name = "upnpLeaseMinutes", IsRequired = false, EmitDefaultValue = true)]
        private int upnpLeaseMinutes;

        public int UPnPLeaseMinutes
        {
            get { return this.upnpLeaseMinutes; }
        }

        [DataMember(Name = "upnpRenewalMinutes", IsRequired = false, EmitDefaultValue = true)]
        private int upnpRenewalMinutes;

        public int UPnPRenewalMinutes
        {
            get { return this.upnpRenewalMinutes; }
        }

        [DataMember(Name = "upnpTimeoutSeconds", IsRequired = false, EmitDefaultValue = true)]
        private int upnpTimeoutSeconds;

        public int UPnPTimeoutSeconds
        {
            get { return this.upnpTimeoutSeconds; }
        }

        [DataMember(Name = "urAccepted", IsRequired = false, EmitDefaultValue = true)]
        private int urAccepted;

        public int UrAccepted
        {
            get { return this.urAccepted; }
        }

        [DataMember(Name = "urUniqueId", IsRequired = false, EmitDefaultValue = false)]
        private string urUniqueId;

        public string UrUniqueId
        {
            get { return this.urUniqueId; }
        }

        [DataMember(Name = "restartOnWakeup", IsRequired = false)]
        private Boolean restartOnWakeup;

        public Boolean RestartOnWakeup
        {
            get { return this.restartOnWakeup; }
        }

        [DataMember(Name = "autoUpgradeIntervalH", IsRequired = false, EmitDefaultValue = true)]
        private int autoUpgradeIntervalH;

        public int AutoUpgradeIntervalH
        {
            get { return this.autoUpgradeIntervalH; }
        }

        [DataMember(Name = "keepTemporariesH", IsRequired = false, EmitDefaultValue = true)]
        private int keepTemporariesH;

        public int KeepTemporariesH
        {
            get { return this.keepTemporariesH; }
        }

        [DataMember(Name = "cacheIgnoredFiles", IsRequired = false)]
        private Boolean cacheIgnoredFiles;

        public Boolean CacheIgnoredFiles
        {
            get { return this.cacheIgnoredFiles; }
        }

        [DataMember(Name = "progressUpdateIntervalS", IsRequired = false, EmitDefaultValue = true)]
        private int progressUpdateIntervalS;

        public int ProgressUpdateIntervalS
        {
            get { return this.progressUpdateIntervalS; }
        }

        [DataMember(Name = "symlinksEnabled", IsRequired = false)]
        private Boolean symlinksEnabled;

        public Boolean SymlinksEnabled
        {
            get { return this.symlinksEnabled; }
        }

        [DataMember(Name = "limitBandwidthInLan", IsRequired = false)]
        private Boolean limitBandwidthInLan;

        public Boolean LimitBandwidthInLan
        {
            get { return this.limitBandwidthInLan; }
        }

        [DataMember(Name = "databaseBlockCacheMiB", IsRequired = false, EmitDefaultValue = true)]
        private int databaseBlockCacheMiB;

        public int DatabaseBlockCacheMiB
        {
            get { return this.databaseBlockCacheMiB; }
        }

        [DataMember(Name = "pingTimeoutS", IsRequired = false, EmitDefaultValue = true)]
        private int pingTimeoutS;

        public int PingTimeoutS
        {
            get { return this.pingTimeoutS; }
        }

        [DataMember(Name = "pingIdleTimeS", IsRequired = false, EmitDefaultValue = true)]
        private int pingIdleTimeS;

        public int PingIdleTimeS
        {
            get { return this.pingIdleTimeS; }
        }

        [DataMember(Name = "minHomeDiskFreePct", IsRequired = false, EmitDefaultValue = true)]
        private int minHomeDiskFreePct;

        public int MinHomeDiskFreePct
        {
            get { return this.minHomeDiskFreePct; }
        }
    }
}

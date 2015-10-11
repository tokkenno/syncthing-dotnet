using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SyncthingApi.Data
{
    [DataContract]
    public class ConfigurationData
    {
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        private int version;

        public int Version
        {
            get { return this.version; }
        }

        [DataMember(Name = "folders", IsRequired = true, EmitDefaultValue = true)]
        private List<FolderData> folders;

        public List<FolderData> Folders
        {
            get { return this.folders; }
        }

        [DataMember(Name = "devices", IsRequired = true, EmitDefaultValue = true)]
        private List<DeviceData> devices;

        public List<DeviceData> Devices
        {
            get { return this.devices; }
        }

        [DataMember(Name = "ignoredDevices", IsRequired = true, EmitDefaultValue = true)]
        private List<DeviceData> ignoredDevices;

        public List<DeviceData> IgnoredDevices
        {
            get { return this.ignoredDevices; }
        }

        [DataMember(Name = "gui", IsRequired = true, EmitDefaultValue = true)]
        private GuiConfigurationData gui;

        public GuiConfigurationData GUI
        {
            get { return this.gui; }
        }

        [DataMember(Name = "options", IsRequired = true, EmitDefaultValue = true)]
        private ConfigurationOptionsData options;

        public ConfigurationOptionsData Options
        {
            get { return this.options; }
        }
    }
}

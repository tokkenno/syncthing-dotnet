using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SyncthingApi.Beans
{
    [DataContract]
    public class Configuration
    {
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        private int version;

        public int Version
        {
            get { return this.version; }
        }

        [DataMember(Name = "folders", IsRequired = true, EmitDefaultValue = true)]
        private List<Folder> folders;

        public List<Folder> Folders
        {
            get { return this.folders; }
        }

        [DataMember(Name = "devices", IsRequired = true, EmitDefaultValue = true)]
        private List<Device> devices;

        public List<Device> Devices
        {
            get { return this.devices; }
        }

        [DataMember(Name = "ignoredDevices", IsRequired = true, EmitDefaultValue = true)]
        private List<Device> ignoredDevices;

        public List<Device> IgnoredDevices
        {
            get { return this.ignoredDevices; }
        }

        [DataMember(Name = "gui", IsRequired = true, EmitDefaultValue = true)]
        private GuiConfiguration gui;

        public GuiConfiguration GUI
        {
            get { return this.gui; }
        }

        [DataMember(Name = "options", IsRequired = true, EmitDefaultValue = true)]
        private ConfigurationOptions options;

        public ConfigurationOptions Options
        {
            get { return this.options; }
        }
    }
}

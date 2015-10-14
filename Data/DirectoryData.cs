using Syncthing.API.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Syncthing.API.Data
{
    public class DirectoryData
    {
        private DirectoryData(String name) { this.name = name; }

        private string name;
        public String Name {  get { return this.name; } }

        private List<DirectoryData> directories = new List<DirectoryData>();
        public List<DirectoryData> Directories { get { return this.directories; } }

        private List<FileData> files = new List<FileData>();
        public List<FileData> Files { get { return this.files; } }

        public static DirectoryData DeserializeJson(string json)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                XmlReader reader = JsonReaderWriterFactory.CreateJsonReader(ms, XmlDictionaryReaderQuotas.Max);
                XElement root = XElement.Load(reader);

                DirectoryData tret = DeserializeDirectoryXml("/", root);
                return tret;
            }
        }

        protected static DirectoryData DeserializeDirectoryXml(String dir, XElement root)
        {
            DirectoryData dd = new DirectoryData(dir);

            foreach (XElement elem in root.Elements())
            {
                XAttribute iname = elem.Attribute("item");
                string name = iname == null ? elem.Name.LocalName : iname.Value;

                if (elem.Attribute("type").Value == "object")
                {
                    dd.directories.Add(DeserializeDirectoryXml(name, elem));
                }
                else if (elem.Attribute("type").Value == "array")
                {
                    dd.files.Add(DeserializeFileXml(name, elem));
                }
                else
                {
                    throw new ApiException("Parser error. API respond is malformed.");
                }
            }

            return dd;
        }

        protected static FileData DeserializeFileXml(String filename, XElement root)
        {
            XElement timenode = root.Elements().First<XElement>();
            XElement sizenode = root.Elements().Skip<XElement>(1).First<XElement>();

            if (timenode == null || sizenode == null) throw new ApiException("Parser error. API respond is malformed. File format error.");
            else
            {
                return new FileData(filename, System.Convert.ToInt64(sizenode.Value), JavascriptFormatHelper.ConvertTime(timenode.Value));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncthing.API.Data
{
    public class FileData
    {
        private string name;
        private long size;
        private DateTime modified;

        public FileData(String name) : this(name, 0) { }

        public FileData(String name, long size) : this(name, 0, DateTime.MinValue) { }

        public FileData(String name, long size, DateTime modified)
        {
            this.name = name;
            this.size = size;
            this.modified = modified;
        }

        public String Name { get { return this.name; } }

        public long Size { get { return this.size; } }

        public DateTime Modified { get { return this.modified; } }
    }
}

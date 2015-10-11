using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyncthingApi
{
    class ApiException : Exception
    {
        public ApiException(String message) : base(message) { }
    }
}

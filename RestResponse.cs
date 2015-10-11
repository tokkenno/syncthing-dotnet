using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyncthingApi
{
    public class RestResponse<T>
    {
        private T data;
        private string error;

        public RestResponse(T data)
        {
            this.data = data;
            this.error = String.Empty;
        }

        public RestResponse(String error)
        {
            this.data = default(T);
            this.error = error;
        }
    }
}

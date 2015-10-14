using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncthing.API.Utils
{
    class JavascriptFormatHelper
    {
        public static DateTime ConvertTime(String jstime)
        {
            jstime = jstime.Remove(jstime.LastIndexOf(":"), 1);

            if (jstime.Contains("."))
                return DateTime.ParseExact(jstime, "yyyy-MM-dd'T'HH:mm:ss.fffffffffK", System.Globalization.CultureInfo.InvariantCulture);
            else
                return DateTime.ParseExact(jstime, "yyyy-MM-dd'T'HH:mm:ssK", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}

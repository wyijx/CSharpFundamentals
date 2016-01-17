using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PreventXSS {
    public class XSSDefender {
        public string SanitizeHTML(string toSanitize, string[] whiteList) {

            string pattern = @"(<)\/?((?!" + string.Join("|", whiteList) + @")[^\/][^>]*)\/?(>)";

            string sanitized = Regex.Replace(toSanitize, pattern, @"&lt;" + "$2" + @"&gt;");

            return sanitized;
        }
    }
}

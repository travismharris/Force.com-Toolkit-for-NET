using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Common.Models.Json
{
    public class HttpHeaders
    {
        [JsonProperty(PropertyName = "header")]
        public Dictionary<string, string> Header { get; set; }

    }
}

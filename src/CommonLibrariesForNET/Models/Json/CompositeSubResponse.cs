using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Common.Models.Json
{
    public class CompositeSubResponse
    {
        [JsonProperty(PropertyName = "body")]
        public object Body { get; set; }

        [JsonProperty(PropertyName = "httpHeaders")]
        public HttpHeaders Headers { get; set; }

        [JsonProperty(PropertyName = "httpStatusCode")]
        public int HttpStatusCode { get; set; }

        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }
    }
}

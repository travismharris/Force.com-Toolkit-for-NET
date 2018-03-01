using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Common.Models.Json
{
    public class CompositeRequest
    {
        [JsonProperty(PropertyName = "allOrNone")]
        public bool AllOrNone { get; set; }

        [JsonProperty(PropertyName = "compositeRequest")]
        public CompositeSubRequest[] CompositeRequests { get; set; }
    }
}

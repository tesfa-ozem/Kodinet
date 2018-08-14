using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kodinet.Logic
{
  
        public enum ValidationMethod { NationalId, Fingerprint }
        public class Filters
        {
            [JsonProperty("fingerprint")]
            public string FingerPrint { get; set; }
            [JsonProperty("id")]
            public string Id { get; set; }
            [JsonProperty("validation_method")]
            public ValidationMethod ValidationMethod { get; set; }

        }
    
}

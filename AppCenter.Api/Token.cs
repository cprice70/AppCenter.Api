using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppCenter.Api
{
    public class Token
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scope")]
        public List<string> Scope { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}

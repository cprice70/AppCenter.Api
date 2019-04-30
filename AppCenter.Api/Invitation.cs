using System;
using Newtonsoft.Json;

namespace AppCenter.Api
{
    public partial class Invitation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }
}

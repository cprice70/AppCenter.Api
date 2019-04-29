using System;
using Newtonsoft.Json;

namespace AppCenter.Api
{
    public partial class Connection
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("serviceType")]
        public string ServiceType { get; set; }

        [JsonProperty("credentialType")]
        public string CredentialType { get; set; }

        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("is2FA")]
        public bool Is2Fa { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppCenter.Api
{
    public partial class DistributionGroupDetails
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("is_public")]
        public bool IsPublic { get; set; }

        [JsonProperty("total_apps_count")]
        public long TotalAppsCount { get; set; }

        [JsonProperty("total_users_count")]
        public long TotalUsersCount { get; set; }

        [JsonProperty("apps")]
        public List<App> Apps { get; set; }
    }
}

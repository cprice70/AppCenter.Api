using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppCenter.Api
{
    public partial class App
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("icon_source")]
        public string IconSource { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("app_secret")]
        public string AppSecret { get; set; }

        [JsonProperty("azure_subscription")]
        public AzureSubscription AzureSubscription { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("member_permissions")]
        public List<string> MemberPermissions { get; set; }

        [JsonProperty("team_permissions")]
        public List<string> TeamPermissions { get; set; }
    }

    public partial class AzureSubscription
    {
        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; }

        [JsonProperty("tenant_id")]
        public string TenantId { get; set; }

        [JsonProperty("subscription_name")]
        public string SubscriptionName { get; set; }

        [JsonProperty("is_billing")]
        public bool IsBilling { get; set; }

        [JsonProperty("is_billable")]
        public bool IsBillable { get; set; }

        [JsonProperty("is_microsoft_internal")]
        public bool IsMicrosoftInternal { get; set; }
    }

    public partial class Owner
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

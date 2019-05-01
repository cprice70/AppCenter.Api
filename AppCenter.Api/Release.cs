using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppCenter.Api
{
    public class Release
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("short_version")]
        public string ShortVersion { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("uploaded_at")]
        public string UploadedAt { get; set; }

        [JsonProperty("destination_type")]
        public string DestinationType { get; set; }

        [JsonProperty("distribution_groups")]
        public List<DistributionGroup> DistributionGroups { get; set; }

        [JsonProperty("distribution_stores")]
        public List<Destination> DistributionStores { get; set; }

        [JsonProperty("destinations")]
        public List<Destination> Destinations { get; set; }

        [JsonProperty("build")]
        public Build Build { get; set; }
    }

    public class Build
    {
        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("commit_hash")]
        public string CommitHash { get; set; }

        [JsonProperty("commit_message")]
        public string CommitMessage { get; set; }
    }

    public class Destination
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_latest")]
        public bool IsLatest { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("publishing_status")]
        public string PublishingStatus { get; set; }

        [JsonProperty("destination_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationType { get; set; }
    }

    public class DistributionGroup
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_latest")]
        public bool IsLatest { get; set; }
    }
}

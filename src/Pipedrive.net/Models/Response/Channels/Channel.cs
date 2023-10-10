using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Pipedrive.net.Models.Response.Channels
{
    public class Channel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("provider_channel_id")]
        public string ProviderChannelId { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("marketplace_client_id")]
        public string MarketplaceClientId { get; set; }

        [JsonProperty("pd_company_id")]
        public long PdCompanyId { get; set; }

        [JsonProperty("pd_user_id")]
        public long PdUserId { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("template_support")]
        public bool TemplateSupport { get; set; }

        [JsonProperty("provider_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChannelProviderType ProviderType { get; set; }
    }
}

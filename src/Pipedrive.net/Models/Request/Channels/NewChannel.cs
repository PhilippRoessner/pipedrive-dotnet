using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Pipedrive.Converters;

namespace Pipedrive
{
    public class NewChannel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("provider_channel_id")]
        public string ProviderChannelId { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("template_support")]
        public bool TemplateSupport { get; set; }

        [JsonProperty("provider_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChannelProviderType ProviderType { get; set; }
    }

    public enum ChannelProviderType
    {
        facebook,
        whatsapp,
        other
    }
}



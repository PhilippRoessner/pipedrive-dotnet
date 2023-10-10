using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Pipedrive.Converters;

namespace Pipedrive
{
    public class ChannelMessageAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("link_expires")]
        public bool LinkExpires { get; set; }

        public ChannelMessageAttachment(string id, string type, string name, long size, string url, string previewUrl, bool linkExpires)
        {
            Id = id;
            Type = type;
            Name = name;
            Size = size;
            Url = url;
            PreviewUrl = previewUrl;
            LinkExpires = linkExpires;
        }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Pipedrive.Converters;

namespace Pipedrive
{
    public class ChannelMessage
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        [JsonProperty("sender_id")]
        public string SenderId { get; set; }

        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("reply_by")]
        public string ReplyBy { get; set; }

        [JsonProperty("conversation_link")]
        public string ConversationLink { get; set; }

        [JsonProperty("attachments")]
        public IEnumerable<ChannelMessageAttachment> Attachments { get; set; }

        public ChannelMessage(string id, string channelId, string senderId, string conversationId, string message, string status, DateTime createdAt, string replyBy, string conversationLink, IEnumerable<ChannelMessageAttachment> attachments)
        {
            Id = id;
            ChannelId = channelId;
            SenderId = senderId;
            ConversationId = conversationId;
            Message = message;
            Status = status;
            CreatedAt = createdAt;
            ReplyBy = replyBy;
            ConversationLink = conversationLink;
            Attachments = attachments;
        }
    }
}



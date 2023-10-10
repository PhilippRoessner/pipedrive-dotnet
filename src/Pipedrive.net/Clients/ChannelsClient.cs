using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Pipedrive.Helpers;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's User API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/Channels">User API documentation</a> for more information.
    public class ChannelsClient : ApiClient, IChannelsClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersClient"/> class.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public ChannelsClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<Channel> UpsertMessage(NewChannelMessage data, string channelId)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Post<Channel>(ApiUrls.ChannelMessageReceive(channelId), data);
        }
    }
}

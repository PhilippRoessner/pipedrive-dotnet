using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Pipedrive.Helpers;
using Pipedrive.net.Models.Response.Channels;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Channels API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/Channels">User API documentation</a> for more information.
    /// !!! Important, you need to use the official api endpoint https://api.pipedirve.com/v1/ not your own subdomain: https://yourname.pipedirve.com/v1/
    /// !!! Woks only with OAuth athentification !!!
    public class ChannelsClient : ApiClient, IChannelsClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersClient"/> class.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public ChannelsClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<Channel> AddChannel(NewChannel data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));
            return ApiConnection.Post<Channel>(ApiUrls.Channel(), data);
        }

        public Task<ChannelMessage> UpsertMessage(ChannelMessage data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Post<ChannelMessage>(ApiUrls.ChannelMessageReceive(), data);
        }
    }
}

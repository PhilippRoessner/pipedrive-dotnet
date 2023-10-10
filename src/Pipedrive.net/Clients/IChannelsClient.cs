using System.Threading.Tasks;

namespace Pipedrive
{
    public interface IChannelsClient
    {
        Task<Channel> UpsertMessage(NewChannelMessage data, string channelId);
    }
}

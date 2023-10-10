using System.Threading.Tasks;

namespace Pipedrive
{
    public interface IChannelsClient
    {
        Task<ChannelMessage> UpsertMessage(ChannelMessage data, string channelId);
    }
}

using System.Threading.Tasks;
using Pipedrive.net.Models.Response.Channels;

namespace Pipedrive
{
    public interface IChannelsClient
    {
        Task<Channel> AddChannel(NewChannel data);
        Task<ChannelMessage> UpsertMessage(ChannelMessage data);
    }
}

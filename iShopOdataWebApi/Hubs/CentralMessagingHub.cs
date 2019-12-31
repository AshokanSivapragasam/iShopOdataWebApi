using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace iShopOdataWebApi.Hubs
{
    public class CentralMessagingHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task CustomEventMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

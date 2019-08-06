using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRCore.SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string name)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, name);
        }
    }
}

using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string rate)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, rate);
        }
    }
}
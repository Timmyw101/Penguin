using Microsoft.AspNetCore.SignalR;

namespace PenguinServer.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.AllExcept(Context.ConnectionId).SendAsync("ReceivedMessage", user, message);
        }
    }
}

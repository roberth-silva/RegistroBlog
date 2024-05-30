using Microsoft.AspNetCore.SignalR;

namespace RegistroBlog.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceivedMessage",user, message);
        }
    }
}

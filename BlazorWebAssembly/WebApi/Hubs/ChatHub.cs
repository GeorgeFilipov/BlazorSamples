using MentorMate.Shared.Models;
using Microsoft.AspNetCore.SignalR;

namespace MentorMate.WebApi.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message)
        {
            message.SendByMe = false;

            await Clients.Others.SendAsync("ReceiveMessage", message);
        }
    }
}

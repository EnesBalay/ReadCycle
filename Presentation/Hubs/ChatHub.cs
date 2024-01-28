using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        // Client'lara mesajı yayınla
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}

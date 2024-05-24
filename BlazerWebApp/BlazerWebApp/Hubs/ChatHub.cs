using Microsoft.AspNetCore.SignalR;
using System.Formats.Asn1;

namespace BlazerWebApp.Hubs;

public class ChatHub : Hub
{
    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        return base.OnDisconnectedAsync(exception);
    }

    public async Task Typing(string userName)
    {
        await Clients.Others.SendAsync("UserTyping", userName);
    }

    public async Task SendMessageToAll(string userName, string message, DateTime dateTime)
    {
        await Clients.All.SendAsync("ReceiveMessage", userName, message, dateTime);
    }
}

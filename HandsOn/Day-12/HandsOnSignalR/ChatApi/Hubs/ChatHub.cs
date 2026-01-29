using Microsoft.AspNetCore.SignalR;


namespace ChatApi.Hubs;


public class ChatHub : Hub//communication gateway
{
    //
    public async Task SendMessage(string user, string message)
    {
        // Broadcast to ALL connected clients
        //It means sending a message or data to every connected client in a network or application simultaneously.
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
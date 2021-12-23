using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System;

namespace BlazorServerApp.Hubs
{
    public class TestHubs : Hub
    {
        public const string HubUrl = "/chatter";

        public async Task Broadcast(string username, string message)
        {
            await Clients.All.SendAsync("Broadcast", username, message);
        }

        public override Task OnConnectedAsync()
        {
            Console.WriteLine($"{Context.ConnectionId} connected");
            return base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception e)
        {
            Console.WriteLine($"Disconnected {e?.Message} {Context.ConnectionId}");
            await base.OnDisconnectedAsync(e);
        }
    }
}

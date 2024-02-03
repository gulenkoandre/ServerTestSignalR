// Ignore Spelling: username

using Microsoft.AspNetCore.SignalR;

namespace ServerTestSignalR
{
    public class ServerHub : Hub
    {
        public async Task Send(string username, string message)
        {
            await this.Clients.All.SendAsync("Receive",username, message);
        }
    }
}

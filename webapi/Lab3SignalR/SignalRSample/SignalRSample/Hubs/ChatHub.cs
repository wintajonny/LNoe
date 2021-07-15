using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace SignalRSample.Hubs
{
    public class ChatHub : Hub
    {

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }


        public async Task SendMessageToAll(string name, string message)
        {
            await Clients.All.SendAsync("BroadCast", HtmlEncoder.Default.Encode(name), HtmlEncoder.Default.Encode(message));
        }

    }
}

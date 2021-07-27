using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace SignalRSample.Hubs
{
    public class ChatHub : Hub
    {

        public async Task SendMessage(string name, string message)
        {
            string nameenc = HtmlEncoder.Default.Encode(name);
            string messageenc = HtmlEncoder.Default.Encode(message);
            await base.Clients.All.SendAsync("BroadcastMessage", nameenc, messageenc);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRFramework.SignalR.Hubs
{    
    public class ChatHub : Hub
    {
        public void SendMessage(string name, string message)
        {
            //發送事件名稱為broadcastMessage
            Clients.All.broadcastMessage(name, message);
        }
    }
}
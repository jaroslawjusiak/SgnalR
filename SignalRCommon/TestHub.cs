using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SignalRCommon
{
    public class TestHub : Hub
    {
        [HubMethodName(TestHubMethods.TestMessage)]
        public async Task SendTestMessage(string sender, string message)
        {
            await Clients.All.SendAsync(TestHubMethods.TestMessage, message);
        }
    }
}

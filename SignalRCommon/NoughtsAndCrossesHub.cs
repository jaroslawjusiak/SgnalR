using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using SignalR.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SignalRCommon
{
    public class NoughtsAndCrossesHub : Hub
    {
        private readonly IDistributedCache _cache;

        public NoughtsAndCrossesHub(IDistributedCache cache)
        {
            this._cache = cache;
        }

        public override Task OnDisconnectedAsync(Exception ex)
        {
            _cache.RemoveAsync(Context.ConnectionId);

            return base.OnDisconnectedAsync(ex);
        }

        [HubMethodName(NoughtsAndCrossesHubMethods.Login)]
        public async Task Login(string username)
        {
            var playerSession = new PlayerSession { ConnectionID = Context.ConnectionId, UserName = username, LoginTime = DateTime.UtcNow};
            var serializedSession = JsonConvert.SerializeObject(playerSession);
            await _cache.SetStringAsync(Context.ConnectionId, serializedSession);
            var info = await _cache.GetStringAsync("NoughtsAndCrosses.Tables");

            //login user
            await Clients.Caller.SendAsync(NoughtsAndCrossesHubMethods.LoginConfirmation, serializedSession, info);
        }

        [HubMethodName(NoughtsAndCrossesHubMethods.LoginConfirmation)]
        public async Task SendLoginConfirmation(string session, string info)
        {
            var bpph = string.Empty;
        }
    }
}

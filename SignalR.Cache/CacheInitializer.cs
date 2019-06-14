using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using SignalR.Cache.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaR.Cache
{
    public class CacheInitializer
    {
        public static void Seed(IDistributedCache _cache)
        {
            _cache.SetString("testTime", DateTime.UtcNow.ToString());
            var table = new Table { Id = Guid.NewGuid(), Name = "Testing table." };
            var serializedTable = JsonConvert.SerializeObject(table);
            _cache.SetString("testingTable", serializedTable);
        }
    }
}

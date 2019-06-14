using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaR
{
    public class CacheInitializer
    {
        public static void Seed(IDistributedCache _cache)
        {
            _cache.SetString("testTime", DateTime.UtcNow.ToString());
        }
    }
}

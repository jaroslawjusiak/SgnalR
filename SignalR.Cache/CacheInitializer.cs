using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using SignalR.Cache.Model;
using SignalR.Cache.Model.NoughtsAndCrosses;
using SignalRCommon;
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
            _cache.SetString("serverStartTime", DateTime.UtcNow.ToString());
            List<NoughtsAndCrossesTable> tables = GenerateTables<NoughtsAndCrossesTable>(10); ;

            var serializedNaCTables = JsonConvert.SerializeObject(tables);
            _cache.SetString("NoughtsAndCrossesTables", serializedNaCTables);
        }

        private static List<T> GenerateTables<T>(int amount) where T: Table
        {
            var tables = new List<Table>();

            if (typeof(T) == typeof(NoughtsAndCrossesTable))
            {
                for (int i = 0; i < amount; i++)
                {
                    var table = new NoughtsAndCrossesTable { Id = Guid.NewGuid(), Name = $"Table {i + 1}" };
                    tables.Add(table);
                }
            }

            return tables as List<T>;
        }
    }
}

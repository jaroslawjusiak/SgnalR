using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using SignalR.Common.Model;
using SignalR.Common.Model.NoughtsAndCrosses;
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
            _cache.SetString("Server.StartTime", DateTime.UtcNow.ToString());
            var tables = GenerateTables<NoughtsAndCrossesTable>(10); ;

            var serializedNaCTables = JsonConvert.SerializeObject(tables);
            _cache.SetString("NoughtsAndCrosses.Tables", serializedNaCTables);
        }

        private static List<T> GenerateTables<T>(int amount) where T: Table, new()
        {
            var tables = new List<T>();

            if (typeof(T) == typeof(NoughtsAndCrossesTable))
            {
                for (int i = 0; i < amount; i++)
                {
                    var table = new T { Id = Guid.NewGuid(), Name = $"Table {i + 1}" };
                    tables.Add(table);
                }
            }

            return tables;
        }
    }
}

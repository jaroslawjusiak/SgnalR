using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using SignalR.Common.Model;

namespace SignaR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDistributedCache _cache;

        public ValuesController(IDistributedCache cache)
        {
            this._cache = cache;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("TestCache")]
        public IActionResult TestCache()
        {
            var serializedTable = _cache.GetString("testingTable");
            Table table = null;
            if (!string.IsNullOrEmpty(serializedTable))
                table = JsonConvert.DeserializeObject<Table>(serializedTable);

            if (table == null)
                return NotFound();

            return Ok(new { CacheCreationTime = _cache.GetString("testTime"), TestingTable = table });
        }
    }
}

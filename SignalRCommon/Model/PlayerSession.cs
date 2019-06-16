using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.Common.Model
{
    public class PlayerSession
    {
        public string UserName { get; set; }
        public string ConnectionID { get; set; }
        public DateTime LoginTime { get; set; }
    }
}

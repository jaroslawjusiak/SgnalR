using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.Cache.Model
{
    public class Game
    {
        public Guid Id { get; set; }
        public Table Table { get; set; }
        public GameStatus Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.Cache.Model.NoughtsAndCrosses
{
    public class NoughtsAndCrossesTable : Table
    {
        public Player Noughts { get; set; }
        public Player Crosses { get; set; }

        //public List<Player> Visitors { get; set; }
    }
}

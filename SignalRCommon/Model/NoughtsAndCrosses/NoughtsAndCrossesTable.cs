using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.Common.Model.NoughtsAndCrosses
{
    public class NoughtsAndCrossesTable : Table
    {
        public PlayerSession Noughts { get; set; }
        public PlayerSession Crosses { get; set; }

        //public List<Player> Visitors { get; set; }
    }
}

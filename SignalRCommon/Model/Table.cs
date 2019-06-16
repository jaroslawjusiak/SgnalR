using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.Common.Model
{
    public abstract class Table
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

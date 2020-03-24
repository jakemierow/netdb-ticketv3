using System;
namespace Ticket
{
    public class Enhancement : Ticket
    {
        public object Software { get; internal set; }
        public object Cost { get; internal set; }
        public object Reason { get; internal set; }
        public object Estimate { get; internal set; }
    }
}




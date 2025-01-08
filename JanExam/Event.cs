using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace JanExam
{
    public enum EventType { Music, Comedy, Theatre }
    internal class Event : IComparable
    {
        //Properties
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; }

        
        // constructors


        //methods
        public int CompareTo(object obj)
        {
            Event @event;
            return @event.CompareTo(EventDate);
        }


    }
}

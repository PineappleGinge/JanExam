using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public EventType TypeOfEvent { get; set; }

        
        // constructors
        public Event(string name, DateTime eventDate, EventType typeofevent)
        {
            Name = name;
            EventDate = eventDate;
            TypeOfEvent = typeofevent;
        }


        //methods
        public int CompareTo(object obj)
        {
            Event @event = (Event)Name;
            return @event.CompareTo(EventDate);
        }

        public override string ToString()
        {

            return $"{Name} - {EventDate}";
        }


    }
}

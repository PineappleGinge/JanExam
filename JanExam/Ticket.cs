using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanExam
{
    public class Ticket
    {
        // properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableTickets { get; set; }

        //constructers

        //methods
    }

    public class VIPTicket : Ticket
    {
        //properties
        public string AdditionalExtras { get; set; }

        public decimal AdditionalCost { get; set; }

        //constructors

        //methods
    }

}

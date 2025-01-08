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
        public Ticket(string name, decimal price, int availabletickets )
        {
            Name = name;
            Price = price;
            AvailableTickets = availabletickets;

        }

        //methods
        public override string ToString()
        {

            return $"{Name} - {Price:C}[Availble - {AvailableTickets}]";
        }
    }

    public class VIPTicket : Ticket
    {
        //properties
        public string AdditionalExtras { get; set; }

        public decimal AdditionalCost { get; set; }

        //constructors
        public VIPTicket(string name, decimal price, decimal additionalcost, string additionalextra, int availabletickets) 
        {
            Name = name;
            Price = price;
            AdditionalCost = additionalcost;
            AdditionalExtras = additionalextra;
            AvailableTickets = availabletickets;
        }

        //methods
        public override string ToString()
        {
            decimal total_cost = AdditionalCost + Price;
            return $"{Name} - {total_cost:C} ({AdditionalExtras})[Availble - {AvailableTickets}]";
        }
    }

}

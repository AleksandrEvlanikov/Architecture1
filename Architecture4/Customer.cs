using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture4
{
    internal class Customer
    {
        private static int counter = 100;

        public int Id { get; }
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

        public Customer()
        {
            Id = ++counter;
        }

        public List<Ticket> GetTickets()
        {
            return Tickets;
        }

        public void SetTickets(List<Ticket> tickets)
        {
            this.Tickets = tickets;
        }

        public int GetId()
        {
            return Id;
        }


    }
}

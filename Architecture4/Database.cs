using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture4
{
    internal class Database
    {
        public Database()
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            Ticket ticket1 = new Ticket();
            Ticket ticket2 = new Ticket();
            Ticket ticket3 = new Ticket();
            Ticket ticket4 = new Ticket();
            Ticket ticket5 = new Ticket();
            Ticket ticket6 = new Ticket();

            customer1.GetTickets().Add(ticket1);
            customer1.GetTickets().Add(ticket2);
            customer1.GetTickets().Add(ticket3);
            customer2.GetTickets().Add(ticket4);
            customer2.GetTickets().Add(ticket5);
            customer3.GetTickets().Add(ticket6);

            Tickets.AddRange(new List<Ticket> { ticket1, ticket2, ticket3, ticket4, ticket5, ticket6 });
            Customers.AddRange(new List<Customer> { customer1, customer2, customer3 });

        }


        private static int counter = 100;

        private List<Customer> Customers { get; } = new List<Customer>();
        private List<Ticket> Tickets { get; } = new List<Ticket>();

        public List<Ticket> GetTickets() 
        { 
            return Tickets; 
        }

        /**
        * Получить актуальную стоимость билета
        * @return
        */
        public double GetTicketAmount()
        {
            double priceTiket = 45;
            //Console.WriteLine($"Билет стоит {priceTiket}р.");
            return priceTiket;
        }
        /**
        * Получить идентификатор заявки на покупку билета
        * @return
         */


        public int CreateTicketOrder(int clientId)
        {
            return ++counter;

        }
    }

}
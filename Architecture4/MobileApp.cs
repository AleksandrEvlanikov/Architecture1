using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Architecture4
{
    internal class MobileApp
    {
        private Customer customer;
        private TicketProvider ticketProvider;

        public MobileApp(TicketProvider ticketProvider, CustomerProvider customerProvider)
        {
            this.ticketProvider = ticketProvider;
            customer = customerProvider.GetCustomer("login", "password");

        }

        public List<Ticket> GetTickets()
        {
            return customer.GetTickets();
        }

        public void SearchTicket(DateTime date)
        {
            customer.SetTickets(ticketProvider.SearchTicket(customer.GetId(), date));
        }

        public bool BuyTicket(string cardNo)
        {
            Console.WriteLine($"Билет забронирован с карты {cardNo} клиентом {customer.GetId()} ");
            return ticketProvider.BuyTicket(customer.GetId(), cardNo);

        }
    }
}

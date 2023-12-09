using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture4
{
    internal class Core
    {
        private CustomerProvider customerProvider { get; }
        private TicketProvider ticketProvider { get; }
        private PaymentProvider paymentProvider { get; }
        private Database Database { get; }

        public Core()
        {
            Database = new Database();
            customerProvider = new CustomerProvider(Database);
            paymentProvider = new PaymentProvider();
            ticketProvider = new TicketProvider(Database, paymentProvider);
        }

        public TicketProvider GetTicketProvider()
        {
            return ticketProvider;
        }

        public CustomerProvider GetCustomerProvider()
        {
            return customerProvider;
        }
    }
}

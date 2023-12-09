using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture4
{
    internal class TicketProvider
    {
        private Database Database;
        private PaymentProvider paymentProvider;

        public TicketProvider(Database database, PaymentProvider paymentProvider)
        {
            // контаракт: проверка на null.
            Contract.Requires(database != null);
            Contract.Requires(paymentProvider != null);


            this.Database = database;
            this.paymentProvider = paymentProvider;
        }

        public List<Ticket> SearchTicket(int clientId, DateTime date) 
        {
            // Контракт: clientId не может быть меньше 0 и date не может быть меньше текущего.
            Contract.Requires(clientId > 0);
            Contract.Requires(date > DateTime.MinValue);

            List<Ticket> tickets = new List<Ticket>();
            foreach (Ticket ticket in Database.GetTickets())
            {
                if(ticket.GetCustomerId() == clientId && ticket.Date == date)
                {
                    tickets.Add(ticket);
                }
            }
            Contract.Ensures(tickets.Count >= 0);
            return tickets;
        }

        public bool BuyTicket( int clientId, string cardNo)
        {
            // Контракт: clientId не может быть меньше 0 и cardNo не может быть null.
            Contract.Requires(clientId > 0);
            Contract.Requires(cardNo != null);


            int orderId = Database.CreateTicketOrder(clientId);
            double amount = Database.GetTicketAmount();
            Console.WriteLine($"Номер заказа {orderId}, был куплил за {amount}р c карты {cardNo}.");

            Contract.Ensures(orderId > 100);
            Contract.Ensures(cardNo != null);
            Contract.Ensures(amount > 0);

            return paymentProvider.BuyTicket(orderId, cardNo, amount);

        }

        public bool CheckTicket(string qrcode)
        {
            // Контракт: qrcode не может быть null.

            Contract.Requires(qrcode != null);


            foreach (Ticket ticket in Database.GetTickets())
            {
                if(ticket.GetQrCode() == qrcode)
                {
                    ticket.SetEnable(false);
                    return true;
                }
            }
            Contract.Ensures(!string.IsNullOrEmpty(qrcode));
            return false;
           
        }
    }
}

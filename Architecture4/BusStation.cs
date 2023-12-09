using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture4
{

    /**
    * Автобусная станция (отдельный комплекс)
    */
    internal class BusStation
    {
        private TicketProvider ticketProvider;

        public BusStation(TicketProvider ticketProvider)
        {
            this.ticketProvider = ticketProvider;
        }

        public bool CheckTicket(string qrCode)
        {
            return ticketProvider.CheckTicket(qrCode);
        }
    }

}

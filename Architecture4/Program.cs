namespace Architecture4
{

    /**
    * Разработать контракты и компоненты системы "Покупка онлайн билетов на автобус в час пик".
    * @param args
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Core core = new Core();
            MobileApp mobileApp = new MobileApp(core.GetTicketProvider(), core.GetCustomerProvider());
            BusStation busStation = new BusStation(core.GetTicketProvider());
            

            mobileApp.BuyTicket("2200 7008 2134 8967");
            mobileApp.BuyTicket("2200 7008 1245 9000");
            mobileApp.BuyTicket("2200 7008 5641 8761");
            mobileApp.SearchTicket(new DateTime());
            List<Ticket> ticketList = mobileApp.GetTickets();



            busStation.CheckTicket("A12F");
           
        }
    }
}

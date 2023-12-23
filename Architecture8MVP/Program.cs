using Architecture8MVP.Models;
using Architecture8MVP.Presenters;
using Architecture8MVP.View;

namespace Architecture7MVP
{
    internal class Program
    {
        /**
        * TODO: Домашнее задание - метод changeReservationTable заработал!
        * @param args
        */
        static void Main(string[] args)
        {
            IModel tableService = new TableService();
            BookingView bookingView = new BookingView();
            BookingPresenter bookingPresenter = new BookingPresenter(tableService, bookingView);
            bookingPresenter.UpdateUILoadTables();
            bookingView.ReservationTable(new DateTime(), 3, "Александр");
            bookingView.ReservationTable(new DateTime(), 1, "Ирина");


            bookingView.ChangeReservationTable(1001, new DateTime(), 4, "Александр");
        }
    }
}

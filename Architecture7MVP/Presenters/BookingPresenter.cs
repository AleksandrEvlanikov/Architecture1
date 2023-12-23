using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture8MVP.Presenters
{
    internal class BookingPresenter : IViewObserver
    {

        private readonly IModel model;
        private readonly IView view;

        public BookingPresenter(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
            this.view.RegisterObserver(this);
        }

        public void UpdateUILoadTables()
        {
            view.ShowTables(model.LoadTables());
        }
        public void UpdateUIReservationTableResult(int reservationNo, int tableNo)
        {
            view.ShowReservationTableResult(reservationNo, tableNo);
        }

        public void OnReservationTable(DateTime orderDate, int tableNo, string name)
        {
            try
            {
                int reservationNo = model.ReservationTable(orderDate, tableNo, name);
                UpdateUIReservationTableResult(reservationNo, tableNo);
            }
            catch (Exception ex) 
            {
                UpdateUIReservationTableResult(-1, -1);
            }
        }

        public void OnChangeReservationTable(int oldReservation, DateTime reservationDate, int tableNo, string name)
        {
            model.ChangeReservationTable(oldReservation, reservationDate, tableNo, name);
            Console.WriteLine($"Бронь изменена. Новый столик: #{tableNo}");
        }
    }
}

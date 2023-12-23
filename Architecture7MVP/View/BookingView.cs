using Architecture8MVP.Models;
using Architecture8MVP.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture8MVP.View
{
    internal class BookingView : IView
    {
        private List<IViewObserver> _observers = new List<IViewObserver>();

        public void RegisterObserver(IViewObserver observer)
        {
            _observers.Add(observer);
        }

        public void ShowReservationTableResult(int reservationNo, int tableNo)
        {
            if( reservationNo > 0)
            {
                Console.WriteLine("________________________________________________________");
                Console.WriteLine($"Столик #{tableNo} успешно забронирован. Номер вашей брони: {reservationNo}\n");
            }
            else
            {
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("Не удалось забронировать столик. Повторите попытку позже.");
            }
        }

        public void ShowTables(List<Table> tables)
        {
            foreach (Table table in tables)
            {
                Console.WriteLine(table);
            }
        }

        public void ChangeReservationTable(int oldReservation, DateTime reservationDate, int tableNo, string name)
        {
            foreach (IViewObserver viewObserver in _observers)
            {
                viewObserver.OnChangeReservationTable(oldReservation, reservationDate, tableNo, name);
            }
        }

        public void ReservationTable(DateTime orderDate, int tableNo, string name)
        {
            foreach (IViewObserver viewObserver in _observers)
            {
                viewObserver.OnReservationTable(orderDate, tableNo, name);
            }
        }
    }
}

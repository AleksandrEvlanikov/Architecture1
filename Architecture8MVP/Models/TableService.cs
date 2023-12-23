using Architecture8MVP.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Architecture8MVP.Models
{
    internal class TableService : IModel
    {
        private List<Table> tables;


        public List<Table> LoadTables()
        {
            if (tables == null) 
            {
                tables = new List<Table>()
                {
                    new Table(),
                    new Table(),
                    new Table(),
                    new Table(),
                    new Table()
                };
            }
            return tables;
        }

        public int ReservationTable(DateTime reservationDate, int tableNo, string name)
        {
            foreach (Table table in tables)
            {
                if(table.No == tableNo)
                {
                    Reservation reservation = new Reservation(table, reservationDate, name);
                    table.Reservations.Add(reservation);
                    return reservation.Id;
                }
            }
            throw new InvalidOperationException("Некорректный номер столика");
        }

        public int ChangeReservationTable(int oldReservation, DateTime reservationDate, int tableNo, string name)
        {
            foreach (Table table in tables)
            {
                var matchReservation = table.Reservations.FirstOrDefault(x => x.Id == oldReservation);
                if (matchReservation != null)
                {
                    table.Reservations.Remove(matchReservation);
                    return ReservationTable(reservationDate, tableNo, name);
                }
            }
            throw new InvalidOperationException("Некорректный номер бронирования");

        }
    }
}

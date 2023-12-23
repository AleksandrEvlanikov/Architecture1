using Architecture8MVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture8MVP.Presenters
{
    internal interface IModel
    {
        List<Table> LoadTables();

        int ReservationTable(DateTime reservationDate, int tableNo, string name);
        int ChangeReservationTable(int oldReservation, DateTime reservationDate, int tableNo, string name);
    }
}

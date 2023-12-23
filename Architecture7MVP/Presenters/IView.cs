using Architecture8MVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture8MVP.Presenters
{
    internal interface IView
    {
        void ShowTables(List<Table> tables);
        void ShowReservationTableResult(int reservationNo, int tableNo);

        void RegisterObserver(IViewObserver observer);
        void ChangeReservationTable(int oldReservation, DateTime reservationDate, int tableNo, string name);

    }
}

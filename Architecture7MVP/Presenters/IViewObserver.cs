using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture8MVP.Presenters
{
    internal interface IViewObserver
    {
        void OnReservationTable(DateTime orderDate, int tableNo, string name);
        void OnChangeReservationTable(int oldReservation, DateTime reservationDate, int tableNo, string name);


    }
}

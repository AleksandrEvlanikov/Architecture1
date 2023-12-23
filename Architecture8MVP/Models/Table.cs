using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture8MVP.Models
{
    internal class Table
    {
        private static int Counter;

        public Table() 
        {
            No = Counter++;
        }

        public int No {  get; private set; }

        public List<Reservation> Reservations { get; private set; } = new List<Reservation>();

        public override string ToString()
        {
            return $"Столик #{No}";
        }



    }
}

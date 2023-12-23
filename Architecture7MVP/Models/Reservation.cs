using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture8MVP.Models
{
    internal class Reservation
    {
        private static int Counter = 1000;
        public int Id {  get; private set; }

        public Table Table; 
        public DateTime DateTime { get; private set; }
        public string Name { get; private set; }

        public Reservation()
        {
            Id = ++Counter;
        }

        public Reservation(Table table, DateTime dateTime, string name) : this()
        {
            Table = table;
            DateTime = dateTime;
            Name = name;
        }
    }
}

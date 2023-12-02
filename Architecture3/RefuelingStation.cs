using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture3
{
    internal class RefuelingStation : IRefueling
    {
        public void Fuel(FuelType type)
        {
            switch(type)
            {
                case FuelType.Diesel: 
                Console.WriteLine("Заправка дизельным топливом");
                    break;
                case FuelType.Gasoline:
                    Console.WriteLine("Заправка бензином");
                    break;


            }
        }

        public string LocationRefuelingStation() => "Пушкина 23, на заправка №1";
    }
}

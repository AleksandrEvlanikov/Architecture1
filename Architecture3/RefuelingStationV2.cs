using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture3
{
    internal class RefuelingStationV2 : IRefueling
    {
        public void Fuel(FuelType fuelType)
        {
            ProcessCarFuel(fuelType);
        }

        public void ProcessCarFuel(FuelType type)
        {
            switch (type)
            {
                case FuelType.Diesel:
                    Console.WriteLine("Заправка дизельным топливом");
                    break;
                case FuelType.Gasoline:
                    Console.WriteLine("Заправка бензином"); 
                    break;
                case FuelType.Gas:
                    Console.WriteLine("Заправка газом");
                    break;

            }
        }
        public string LocationRefuelingStation() => "Ленина 246, на заправка №2";

    }
}

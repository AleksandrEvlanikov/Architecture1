using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture3
{
    internal class CarWash : IWiping
    {
        public void WipHeadlights()
        {
            Console.WriteLine("Помыли фары.");
        }

        public void WipMirrors()
        {
            Console.WriteLine("Помыли стекла");
        }

        public void WipWindshield()
        {
            Console.WriteLine("Помыли лобовое стекло");
        }

        public void AutoWashCar(Car car)
        {
            Console.WriteLine($"{car.Make} {car.Model} помыли.");
        }
        public string LocationRefuelingStation() => "Мира 126, на мойку";

    }
}

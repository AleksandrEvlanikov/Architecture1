using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture3
{
    internal class ServiceStation : IRefueling, IWiping
    {
        public void Fuel(FuelType fuelType)
        {
        }

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
        public string LocationRefuelingStation() => "Мира 126, в автосервис";

    }
}

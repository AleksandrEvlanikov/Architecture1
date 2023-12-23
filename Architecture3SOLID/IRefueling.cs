using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture3
{
    internal interface IRefueling
    {
        /**
        * Заправка
        */
        void Fuel(FuelType fuelType);
    }
}

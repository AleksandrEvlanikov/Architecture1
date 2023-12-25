using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.ModelElements
{
    internal class Power
    {
        private int ThrowPower {  get; set; }

        public Power(int throwPower)
        {
            ThrowPower = throwPower;
        }
    }
}

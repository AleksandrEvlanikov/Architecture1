using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture3
{
    internal class CommonCar : Car
    {

        public CommonCar(string make, string model, Color color) : base(make, model, color)
        {
            WheelsCount = 4;
        }

        public override void Movement(string point)
        {
            Console.WriteLine($"{Make} {Model} едет по адресу {point}");

        }

        public override void Maintenance()
        {
            Console.WriteLine($"{Make} {Model} проходит обслуживание");
        }

        public override bool GearShifting()
        {
            return false;
        }


        public override bool SwitchHeadlights()
        {
            return false;
        }


        public override bool SwitchWipers()
        {
            return false;
        }
    }
}


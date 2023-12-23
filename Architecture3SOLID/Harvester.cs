using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Architecture3
{
    internal class Harvester : Car
    {
        public Harvester(string make, string model, Color color, Color color1) : base(make, model, color)
        {
            WheelsCount = 6;
        }

        public void Sweeping()
        {
            Console.WriteLine("Автомобиль метет улицу.");
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


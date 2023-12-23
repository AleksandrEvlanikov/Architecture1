using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Architecture3
{
    internal class SportCar : Car
    {
        public SportCar(string make, string model, Color color, int wheelsCount) : base(make, model, color)
        {
            this.WheelsCount = wheelsCount;
        }

        public static SportCar Create (string make, string model, Color color)
        {
            return Create(make, model, color, 4);
        }

        private static SportCar Create(string make, string model, Color color, int wheelsCount)
        {
            if (wheelsCount < 3 && wheelsCount > 10) 
            {
                throw new Exception("Недопустимое кол-во колес."); 
            }
            return new SportCar(make, model, color, wheelsCount);
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

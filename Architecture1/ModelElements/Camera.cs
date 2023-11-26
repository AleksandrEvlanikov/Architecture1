using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.ModelElements
{

    /**
    * Камера
    * TODO: Доработать самостоятельно в рамках домашней работы
    */


    internal class Camera
    {
        private List<Point3D> Point3D { get; } = new List<Point3D>();
        private List<Angle3D> Angle { get; } = new List<Angle3D>();



        public void Rotate(Angle3D angle)
        {
            this.Angle.Add(angle);
            Console.WriteLine("Повернул камеру ...");
        }

        public void Move(Point3D point)
        {
            this.Point3D.Add(point);
            Console.WriteLine($"Переместил камеру на координаты {point.ToString()}");
        }


    }


}

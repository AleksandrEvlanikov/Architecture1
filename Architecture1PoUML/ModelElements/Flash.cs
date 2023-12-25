using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.ModelElements
{

    /**
    * Источник света
     * TODO: Доработать самостоятельно в рамках домашней работы
    */

    internal class Flash
    {
        private List<Point3D> Point3D { get; } = new List<Point3D>();
        private List<Angle3D> Angle { get; } = new List<Angle3D>();
        private List<ColorFlash> ColorFlashes { get; } = new List<ColorFlash>();
        private List<Power> Powers { get; } = new List<Power>();

        public Flash(List<ColorFlash> colorFlashes)
        {
            ColorFlashes = colorFlashes;
        }

        public Flash(List<Point3D> point3D, List<Angle3D> angle, List<ColorFlash> colorFlashes, List<Power> powers)
        {
            Point3D = point3D;
            Angle = angle;
            this.ColorFlashes = colorFlashes;
            this.Powers = powers;
        }

        public Flash()
        {
        }

        public void ThrewFlesh()
        {
            Console.WriteLine("Кинул флешку.");
        }

        public void Rotate(Angle3D angle)
        {
            this.Angle.Add(angle);
            Console.WriteLine("Повернул камеру ...");
        }

        public void Move(Point3D point)
        {
            this.Point3D.Add(point);
            Console.WriteLine("Переместил камеру ...");
        }
    }
}

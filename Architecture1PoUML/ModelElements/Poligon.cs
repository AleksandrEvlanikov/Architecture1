using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.ModelElements
{
    internal class Poligon
    {
        private List<Point3D> Points { get;  } = new List<Point3D>();

        public Poligon(List<Point3D> points)
        {
            this.Points = points;
        }

        public Poligon()
        {
        }
    }
}

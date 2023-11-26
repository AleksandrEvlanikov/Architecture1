using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.ModelElements
{
    internal class Vector3D
    {
        private Point3D point { get; set; }

        public Vector3D(Point3D point)
        {
            this.point = point;
        }
    }
}

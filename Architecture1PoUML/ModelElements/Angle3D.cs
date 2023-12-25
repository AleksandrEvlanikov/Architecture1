using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.ModelElements
{
    internal class Angle3D
    {
        private Vector3D Vector1 { get; }
        private Vector3D Vector2 { get; }
        private double Angle { get; }


        public Angle3D(Vector3D vector1, Vector3D vector2)
        {
            this.Vector1 = vector1;
            this.Vector2 = vector2;
        }

    }
}

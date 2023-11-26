using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.ModelElements
{
    internal class ColorFlash
    {
        private byte Red {  get; set; }
        private byte Green { get; set; }
        private byte Blue { get; set; }

        public ColorFlash(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}

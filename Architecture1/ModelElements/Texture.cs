using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.ModelElements
{
    internal class Texture
    {
        private static int counter = 1000;

        private int Id { get; }

        private string Name { get; }

        public Texture(int id, string name)
        {
            this.Name = name;
            id = counter++;

        }
    }
}

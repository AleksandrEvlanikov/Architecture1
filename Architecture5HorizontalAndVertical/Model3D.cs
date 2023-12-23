using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture5
{
    internal class Model3D : IEntity
    {
        private static int counter = 10000;
        private int Id;
        public List<Texture> textures { get; private set; } = new List<Texture>();

        public Model3D(int id)
        {
            Id = id;
        }
        public Model3D()
        {
            Id = ++counter;
        }

        public Model3D(List<Texture> textures)
        {
            this.textures = textures;
        }

        public override string ToString()
        {
            return $"Model #{Id}";
        }

        public int GetId()
        {
            return Id;
        }
    }
}

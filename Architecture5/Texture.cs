using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture5
{
    internal class Texture : IEntity
    {
        private static int Counter = 5000;
        private int Id;

        public Texture()
        {
        }

        public Texture(int id)
        {
            Id = ++Counter;
        }



        public int GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return $"Текстура #{Id}";
        }
    }
        
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.ModelElements
{
    internal class PoligonalModel
    {
        private List<Poligon> poligons { get; } = new List<Poligon>();
        private List<Texture> textures {  get; } = new List<Texture>();
    }
}

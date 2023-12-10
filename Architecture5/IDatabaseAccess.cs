using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture5
{
    internal interface IDatabaseAccess
    {
        void AddEntity(IEntity entity);
        void RemoveEntity(IEntity entity);
        List<Texture> GetAllTextures();
        List<Model3D> GetAllModels();
        Model3D CreateModel();
    }
}


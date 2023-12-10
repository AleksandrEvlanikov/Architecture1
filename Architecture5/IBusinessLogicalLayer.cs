using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture5
{
    internal interface IBusinessLogicalLayer
    {
        List<Model3D> GetAllModels();
        List<Texture> GetAllTextures();
        void RenderModel(Model3D model);
        void RenderAllModels();

        Model3D CreateModel();
        void RemovModel(Model3D modelToRemove);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture5
{
    internal class EditorBusinessLogicalLayer : IBusinessLogicalLayer
    {
        private IDatabaseAccess databaseAccess;
        private Random random = new Random();

        public EditorBusinessLogicalLayer(IDatabaseAccess databaseAccess)
        {
            this.databaseAccess = databaseAccess;
        }

        public Model3D CreateModel()
        {
            Model3D newModel = new Model3D();
            databaseAccess.AddEntity(newModel);
            return newModel;
        }
        public void RemovModel(Model3D modelToRemove)
        {
            //Model3D model3D = new Model3D();
            databaseAccess.RemoveEntity(modelToRemove);
        }

        public List<Model3D> GetAllModels()
        {
            return databaseAccess.GetAllModels();
        }

        public List<Texture> GetAllTextures()
        {
            return databaseAccess.GetAllTextures();
        }

        public void RenderAllModels()
        {
            foreach (Model3D model3D in GetAllModels())
            {
                ProcessRender(model3D);
            }
        }

        public void RenderModel(Model3D model3D)
        {
            ProcessRender(model3D);
        }

        private void ProcessRender(Model3D model3D)
        {
            try
            {
                Thread.Sleep(2500 - random.Next(2000));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}

using Architecture1.ModelElements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.InMemoryModel
{
    /**
     * Хранилище 3D-элементов
    * TODO: Доработать самостоятельно в рамках домашней работы
    */


    internal class ModelStore : IModelChanger
    {
        private List<IModelChanger> observer = new List<IModelChanger>();
        private List<Scene> scenes = new List<Scene>();
        private List<Flash> flashes = new List<Flash>();
        private List<Camera> cameras = new List<Camera>();
        private List<PoligonalModel> poligonalModels = new List<PoligonalModel>();


        ColorFlash color = new ColorFlash(255,255,255);
        PoligonalModel model = new PoligonalModel();
        public void GetScene()
        {
            Scene scene = new Scene(flashes, poligonalModels, cameras, 5);
            Flash flash = new Flash(new List<ColorFlash> { color });

            AddModel(model);
            AddFlash(flash);
            RegisterModelChanger(scene);
            NotifyChange();
        }

        public void AddScene(Scene scene)
        {
            scenes.Add(scene);
            NotifyChange();
        }

        public void RemoveScene(Scene scene)
        {
            scenes.Remove(scene);
            NotifyChange();
        }

        public void AddFlash(Flash flash)
        {
            flashes.Add(flash);
            NotifyChange();
        }

        public void RemoveFlash(Flash flash)
        {
            flashes.Remove(flash);
            NotifyChange();
        }

        public void AddCamera(Camera camera)
        {
            cameras.Add(camera);
            NotifyChange();
        }
        public void RemoveCamera(Camera camera)
        {
            cameras.Remove(camera);
            NotifyChange();
        }

        public void AddModel(PoligonalModel model)
        {
            poligonalModels.Add(model);
            NotifyChange();
        }

        public void RemoveModel(PoligonalModel model)
        {
            poligonalModels.Remove(model);
            NotifyChange();
        }

        public void RegisterModelChanger(IModelChanger modelChanger) 
        {  
            observer.Add(modelChanger); 
        }

        public void RemoveModelChanger(IModelChanger modelChanger) 
        { 
            observer.Remove(modelChanger);
        }

        /**
        * Нотификация изменений на уровне хранилища
        */

        private void NotifyChange()
        {
            
            foreach (IModelChangedObserver observer in observer)
            {
                observer.ApplyUpdateModel();
                
            }
        }


    }
}

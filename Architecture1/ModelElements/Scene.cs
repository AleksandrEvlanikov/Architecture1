using Architecture1.InMemoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.ModelElements
{
    /**
    * Сцена
    * TODO: Доработать самостоятельно в рамках домашней работы
     */

    internal class Scene : IModelChangedObserver, IModelChanger
    {
        private List<Flash> Flashes { get; } = new List<Flash>();
        private List<PoligonalModel> Models { get; } = new List<PoligonalModel> ();
        private List<Camera> Cameras { get; } = new List<Camera>();
        private int Id {  get; set; }

        public Scene(List<Flash> flashes, List<PoligonalModel> models, List<Camera> cameras, int id)
        {
            Flashes = flashes;
            Models = models;
            Cameras = cameras;
            Id = id;
        }

        public void AddFlash(Flash flash)
        {
            Flashes.Add(flash);
            Console.WriteLine("Добавили флешку");
        }

        public void RemoveFlash(Flash flash)
        {
            Flashes.Remove(flash);
        }

        public void AddModel(PoligonalModel model)
        {
            Models.Add(model);
            Console.WriteLine("Добавили модель");

        }

        public void RemoveModel(PoligonalModel model)
        {
            Models.Remove(model);
        }

        public void AddCamera(Camera camera)
        {
            Cameras.Add(camera);
            Console.WriteLine("Добавили камеру");

        }
        public void RemoveCamera(Camera camera)
        {
            Cameras.Remove(camera);
        }

        public void ClearScene()
        {
            Models.Clear();
            Cameras.Clear();
            Flashes.Clear();
        }

        public void ApplyUpdateModel()
        {
            Console.WriteLine("Сцена реагирует на изменения ...");

        }

        public void RegisterModelChanger(IModelChanger modelChanger)
        {
            throw new NotImplementedException();
        }

        public void RemoveModelChanger(IModelChanger modelChanger)
        {
            throw new NotImplementedException();
        }
    }
}

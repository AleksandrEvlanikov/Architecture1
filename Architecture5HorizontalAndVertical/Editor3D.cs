using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture5
{
    internal class Editor3D : IUILayer
    {
        private ProjectFile projectFile;
        private IBusinessLogicalLayer businessLogicalLayer;
        private IDatabaseAccess databaseAccess;
        private IDatabase database;
        private List<Model3D> models;


        public Editor3D()
        {
            models = new List<Model3D>();
        }

        public void Initialize()
        {
            database = new EditorDatabase(projectFile);
            databaseAccess = new EditorDatabaseAccess(database);
            businessLogicalLayer = new EditorBusinessLogicalLayer(databaseAccess);
        }



        public void OpenProject(string fileName)
        {
            projectFile = new ProjectFile(fileName, 1, "...", false);
            Initialize();
        }

        public void RemovModel()
        {
            //List<Model3D> models = new List<Model3D>(businessLogicalLayer.GetAllModels());
            //models = new List<Model3D>(businessLogicalLayer.GetAllModels());
            Console.WriteLine("Введите ИД модели, которую хотите удалить:");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText, out int integerValue))
            {
                Model3D modelToRemov = models.FirstOrDefault(models => models.GetId() == integerValue);

                if(modelToRemov != null)
                {
                    businessLogicalLayer.RemovModel(modelToRemov);
                    //models.Remove(modelToRemov);
                    Console.WriteLine($"Модель с ИД {integerValue} удалена успешно.");
                }
                else
                {
                    Console.WriteLine($"Модель с ИД {integerValue} не найдена.");

                }
            }
            else
            {
                Console.WriteLine("Номер модели указан некорректно.");
            }
        }

        public void PrintAllModels()
        {
            //List<Model3D> models = new List<Model3D>(businessLogicalLayer.GetAllModels());
            models = businessLogicalLayer.GetAllModels();
            
            for (int i = 0; i < models.Count; i++)
            {
                Console.WriteLine($"==={i}===");
                Console.WriteLine(models[i]);
                foreach (Texture texture in models[i].textures)
                {
                    Console.WriteLine($"{texture}");
                }
            }
        }

        public void PrintAllTextures()
        {
            var textures = businessLogicalLayer.GetAllTextures();
            for (int i = 0; i < textures.Count; i++)
            {
                Console.WriteLine($"==={i}===");
                Console.WriteLine(textures[i]);
            }

        }

        public void RenderAll()
        {
            Console.WriteLine("Подождите ...");
            var startTime = DateTime.Now;
            businessLogicalLayer.RenderAllModels();
            var endTime = DateTime.Now;
            var elepsedTime = endTime - startTime;
            Console.WriteLine($"Операция выполнена за {elepsedTime.TotalMilliseconds}мс");
        }

        public void RenderModel(int i)
        {
            var models = businessLogicalLayer.GetAllModels();
            if (i < 0 || i > models.Count - 1)
            {
                throw new ArgumentException("Номер модели указан некорректною.");
            }
            Console.WriteLine("Подождите ...");
            var startTime = DateTime.Now;
            businessLogicalLayer.RenderModel(models[i]);
            var endTime = DateTime.Now;
            var elepsedTime = endTime - startTime;
            Console.WriteLine($"Операция выполнена за {elepsedTime.TotalMilliseconds}мс");

        }

        public void SaveProject()
        {
            Console.WriteLine("Изменения успешно сохранены.");
            database.Save();
        }

        public void ShowProjectSettings()
        {
            Console.WriteLine("*** Project v1 ***");
            Console.WriteLine("******************");
            Console.WriteLine($"fileName: {projectFile.FileName}");
            Console.WriteLine($"setting1: {projectFile.Setting1}");
            Console.WriteLine($"setting2: {projectFile.Setting2}");
            Console.WriteLine($"setting3: {projectFile.Setting3}");
            Console.WriteLine("******************");

        }

        public void CreateNewModel()
        {
            Model3D newModel = businessLogicalLayer.CreateModel();
            Console.WriteLine($"Новая модель создана {newModel}");
        }
    }
}

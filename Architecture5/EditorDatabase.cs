using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture5
{
    internal class EditorDatabase : IDatabase
    {
        private readonly ProjectFile projectFile;
        private List<IEntity> entities = new List<IEntity>();
        private Random random = new Random();

        public EditorDatabase(ProjectFile projectFile)
        {
            this.projectFile = projectFile;
            Load();
        }

        public List<IEntity> GetAll()
        {
            // Ленивая загрузка
            if (entities == null)
            {
                entities = new List<IEntity>();
                int modelCount = random.Next(5, 11);
                for (int i = 0; i < modelCount; i++)
                {
                    GenerateModelAndTextures();
                }
            }
            return entities;
        }

        public void GenerateModelAndTextures()
        {
            Model3D model3D = new Model3D();
            int textureCount = random.Next(3);
            for (int i = 0; i < textureCount; i++)
            {
                Texture texture = GenerateTexture();
                model3D.textures.Add(texture);
                entities.Add(texture);
            }
            entities.Add(model3D);
        }

        private Texture GenerateTexture()
        {
            return new Texture();
        }

        public void Load()
        {
            //TODO: Загрузка всех сущностей проекта (модели, текстуры)
        }

        public void Save()
        {
            //TODO: Сохранение текущего состояния всех сущностей проекта
        }
    }
}

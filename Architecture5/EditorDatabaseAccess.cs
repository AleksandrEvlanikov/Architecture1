using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture5
{
    internal class EditorDatabaseAccess : IDatabaseAccess
    {

        private readonly IDatabase editorDatabase;

        public EditorDatabaseAccess(IDatabase editorDatabase)
        {
            this.editorDatabase = editorDatabase;
        }


        public void AddEntity(IEntity entity)
        {
            editorDatabase.GetAll().Add(entity);
        }

        public Model3D CreateModel()
        {
            Model3D newModel = new Model3D();
            editorDatabase.GetAll().Add(newModel);
            return newModel;
        }

        public List<Model3D> GetAllModels()
        {
            List<Model3D> models = new List<Model3D>();
            foreach (IEntity entity in editorDatabase.GetAll())
            {
                if (entity is Model3D)
                {
                    models.Add((Model3D)entity);
                }
            }
            return models;
        }

        public List<Texture> GetAllTextures()
        {
            List<Texture> texturs = new List<Texture>();
            foreach (IEntity entity in editorDatabase.GetAll())
            {
                if (entity is Texture)
                {
                    texturs.Add((Texture)entity);
                }
            }
            return texturs;
        }

        public void RemoveEntity(IEntity entity)
        {
            editorDatabase.GetAll().Remove(entity);
        }
    }
}

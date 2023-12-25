using Architecture1.InMemoryModel;
using Architecture1.ModelElements;

namespace Architecture1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();
            Flash flash = new Flash();
            Camera camera = new Camera();
            Point3D point3D1 = new Point3D(12, 2, 8);
            Point3D point3D2 = new Point3D(-12, 2, 8);
            Vector3D vector1 = new Vector3D(point3D1);
            Vector3D vector2 = new Vector3D(point3D2);
            Angle3D angle3D = new Angle3D(vector1, vector2);


            ModelStore modelStore = new ModelStore();
            modelStore.RegisterModelChanger(observer1);
            modelStore.RegisterModelChanger(observer2);

            modelStore.GetScene();
            flash.ThrewFlesh();

            camera.Rotate(angle3D);
            camera.Move(point3D1);

            modelStore.AddModel(new PoligonalModel());



        }
    }
}

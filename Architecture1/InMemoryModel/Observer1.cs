using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.InMemoryModel
{
    public class Observer1 : IModelChangedObserver, IModelChanger
    {
        public void ApplyUpdateModel()
        {
            Console.WriteLine("Observer1 реагирует на изменения ...");
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

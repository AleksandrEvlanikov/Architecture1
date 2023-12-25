using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.InMemoryModel
{
    public interface IModelChanger
    {
        void RegisterModelChanger(IModelChanger modelChanger);
        void RemoveModelChanger(IModelChanger modelChanger);
    }
}

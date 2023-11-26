using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture1.InMemoryModel
{
    internal interface IModelChangedObserver
    {
        void ApplyUpdateModel();
    }
}

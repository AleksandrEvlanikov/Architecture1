using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture5
{
    /**
    * Интерфейс БД
    */
    internal interface IDatabase
    {
        void Load();
        void Save();

        List<IEntity> GetAll();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.notes.infrastructure.persistance
{
    internal class ModelBuilder
    {
        public ModelBuilder ApplyConfiguration<T>(IModelConfiguration<T> modelConfiguration) where T : class
        {
            //TODO: добавление конфигурации маппинга объекта некоторого типа к структуре таблицы базы данных ...

            return this;
        }
    }
}

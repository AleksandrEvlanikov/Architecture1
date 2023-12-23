using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.notes.infrastructure.persistance
{
    internal abstract class DbContext
    {
        protected IDatabase Database { get; }

        protected DbContext(IDatabase database)
        {
            Database = database;
        }

        protected abstract void OnModelCreating(ModelBuilder modelBuilder);

        public bool SaveChanges()
        {
            //TODO: Сохранение изменений в базе данных

            return true;
        }
    }
}

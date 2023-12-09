using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture4
{
    internal class CustomerProvider
    {
        private Database database;

        public CustomerProvider(Database database)
        {
            // Контракт: проверка на null.
            Contract.Requires(database != null);


            this.database = database;
        }

        public Customer GetCustomer(string login, string password)
        {
            // Контракт: login и password не может быть null.
            Contract.Requires(login != null);
            Contract.Requires(password != null);

            //TODO: Процесс аутентификации
            return new Customer();
        }
    }
}

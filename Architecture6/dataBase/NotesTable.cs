using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.dataBase
{
    internal class NotesTable
    {
        private Random random = new Random();

        private List<NotesRecord> Records;

        public List<NotesRecord> GetRecords()
        {
            PrepareRecords();
            return Records;
        }

        private void PrepareRecords()
        {
            if (Records == null)
            {
                Records = new List<NotesRecord>();
                int recordsCount = 5 + random.Next(10);
                for (int i = 0; i < recordsCount; i++)
                {
                    Records.Add(new NotesRecord($"Title #{i}", $"detalis #{i}"));
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.dataBase
{
    internal class NotesRecord
    {
        public static int Counter;
        public int UserId {  get; set; }
        public int Id { get; set; }
        public string Title {  get; set; }
        public string Details {  get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditDate { get; set; }

        public NotesRecord()
        {
            UserId = 20001;
            Id = Counter++;
            
        }

        public NotesRecord(string title, string details) : this()
        {
            Title = title;
            Details = details;
            CreationDate = DateTime.Now;
        }
    }
}

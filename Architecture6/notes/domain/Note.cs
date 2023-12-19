using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.notes.domain
{
    internal class Note
    {
        private static int Counter;
        public int UserId { get; set; }
        public int Id { get;  set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get;  set; }
        public DateTime EditDate { get; set; }

        public Note(int userId, int id, string title, string details, DateTime creationDate)
        {
            this.Id = id;
            this.Title = title;
            this.Details = details;
            this.CreationDate = creationDate;
            this.UserId = userId;

        }

        public override string ToString()
        {
            return $"Note{{userId={UserId}, id={Id}, title='{Title}', details='{Details}', creationDate={CreationDate}, editDate={EditDate}}}";
        }

    }
}

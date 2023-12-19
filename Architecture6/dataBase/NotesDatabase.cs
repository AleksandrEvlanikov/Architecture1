using Architecture6.notes.infrastructure.persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.dataBase
{
    internal class NotesDatabase : IDatabase
    {
        private NotesTable _notesTable = new NotesTable();
        public NotesTable GetNotesTable()
        {
            return this._notesTable;
        }
    }
}

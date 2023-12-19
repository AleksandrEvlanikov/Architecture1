using Architecture6.dataBase;
using Architecture6.notes.application.interfaces;
using Architecture6.notes.domain;
using Architecture6.notes.infrastructure.persistance.configuration;
using System.Data.Entity;

namespace Architecture6.notes.infrastructure.persistance
{
    internal class DatabaseContext : DbContext, INotesDatabaseContext
    {
        public DatabaseContext(IDatabase database) : base(database)
        {
        }

        public List<Note> GetAll()
        {
            List<Note> notesList = new List<Note>();

            var notesDatabase = Database as NotesDatabase;
            if (notesDatabase != null)
            {
                foreach (NotesRecord record in notesDatabase.GetNotesTable().GetRecords())
                {
                    notesList.Add(new Note(
                        record.UserId,
                        record.Id,
                        record.Title,
                        record.Details,
                        record.CreationDate
                    ));
                }
            }

            return notesList;
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
        }
    }

}



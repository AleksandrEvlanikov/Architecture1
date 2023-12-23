using Architecture6.notes.application.interfaces;
using Architecture6.notes.domain;
using Architecture6.notes.infrastructure.persistance;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.notes.application
{
    internal class ConcreteNoteEditor : INoteEditor
    {

        private readonly INotesDatabaseContext _databaseContext;
        private  readonly INotesPresenter _presenter;

        public ConcreteNoteEditor(INotesPresenter presenter, INotesDatabaseContext databaseContext)
        {
            _presenter = presenter;
            _databaseContext = databaseContext;
        }

        public bool Add(Note item)
        {
            _databaseContext.GetAll().Add(item);
            return _databaseContext.SaveChanges();
        }

        public bool Edit(Note item)
        {
            if (item == null)
            {
                return false;
            }

            var note = GetById(item.Id);
            if (note != null)
            {
                return false;
            }
            note.Title = item.Title;
            note.Details = item.Details;
            note.EditDate = DateTime.Now;
            note.UserId = item.UserId;

            return _databaseContext.SaveChanges();
        }

        public List<Note> GetAll()
        {
            return _databaseContext.GetAll();
        }


        public Note? GetById(int id)
        {
            var note = _databaseContext.GetAll().FirstOrDefault(p => p.Id == id);
            return note;
        }

        public void PrintAll()
        {
            _presenter.PrintAll(GetAll());
        }

        public void RemovOnePart()
        {
            _presenter.RemovOnePart(GetAll());
        }


        public bool Remove(Note item)
        {
            _databaseContext.GetAll().Remove(item);
            return _databaseContext.SaveChanges();
        }

    }
}

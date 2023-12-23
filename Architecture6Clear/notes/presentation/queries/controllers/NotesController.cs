using Architecture6.notes.application.interfaces;
using Architecture6.notes.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.notes.presentation.queries.controllers
{
    internal class NotesController : Controller
    {
        private readonly INoteEditor noteEditor;

        public NotesController(INoteEditor noteEditor)
        {
            this.noteEditor = noteEditor;
        }

        public void RouteAddNote(Note note)
        {
           this.noteEditor.Add(note);
        }

        public void RouteRemoveNote(Note note)
        {
           this.noteEditor?.Remove(note);
        }

        public void RouteGetAll()
        {
            noteEditor.PrintAll();
        }

        public void RemovOnePart()
        {
            noteEditor.RemovOnePart();
        }

    }
}

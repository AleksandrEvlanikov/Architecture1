

using Architecture6.dataBase;
using Architecture6.notes.application;
using Architecture6.notes.domain;
using Architecture6.notes.infrastructure.persistance;
using Architecture6.notes.presentation.queries.controllers;
using Architecture6.notes.presentation.queries.views;

namespace Architecture6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotesController notesController = new NotesController(new ConcreteNoteEditor(new NotesConsolePresenter()
                ,new DatabaseContext(new NotesDatabase())
            )
            );
            
            notesController.RouteGetAll();
            notesController.RemovOnePart();

        }
    }
}

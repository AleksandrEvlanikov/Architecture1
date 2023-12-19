using Architecture6.notes.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.notes.application.interfaces
{
    internal interface INotesPresenter
    {
        void PrintAll(List<Note> notes);

        void RemovOnePart(List<Note> notes);
    }
}

using Architecture6.notes.domain;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.notes.application.interfaces
{
    internal interface IEditor<T, TId>
    {
        bool Add (T item);
        bool Remove (T item);
        bool Edit (T item);
        T? GetById(TId id);
        List<T> GetAll ();

        void RemovOnePart();

    }
}

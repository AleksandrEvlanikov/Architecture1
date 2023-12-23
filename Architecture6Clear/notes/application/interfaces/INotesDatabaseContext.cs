using Architecture6.notes.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture6.notes.application.interfaces
{
    internal interface INotesDatabaseContext
    {
        List<Note> GetAll();
        bool SaveChanges();
    }
}

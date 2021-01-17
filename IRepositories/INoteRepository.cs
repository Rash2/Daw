using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes_App.Entities;

namespace Notes_App.IRepositories
{
    public interface INoteRepository : IGenericRepository<Note>
    {
        Note GetNoteAllDetails(int id);
        List<Note> GetNotesAllDetails();
    }
}

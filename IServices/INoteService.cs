using Notes_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_App.IServices
{
    public interface INoteService
    {
        Note Create(Note note);
        Note Get(int id);
        Note Update(Note note);
        bool Delete(int id);
        List<Note> GetAll();

    }
}

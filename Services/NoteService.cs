using Notes_App.Entities;
using Notes_App.IRepositories;
using Notes_App.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_App.Services
{
    public class NoteService: INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public Note Create(Note note)
        {
            _noteRepository.Create(note);
            _noteRepository.SaveChanges();

            return _noteRepository.GetNoteAllDetails(note.NoteId);
        }

        public bool Delete(int id)
        {
            var entity = _noteRepository.FindById(id);
            if (entity != null)
            {
                _noteRepository.Delete(entity);
                _noteRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Note Get(int id)
        {
            return _noteRepository.GetNoteAllDetails(id);
        }

        public List<Note> GetAll()
        {
            return _noteRepository.GetNotesAllDetails();
        }

        public Note Update(Note note)
        {
            if (_noteRepository.FindByIdAndForget(note.NoteId) == null) return null;
            _noteRepository.Update(note);
            _noteRepository.SaveChanges();
            return _noteRepository.GetNoteAllDetails(note.NoteId);
        }
    }
}

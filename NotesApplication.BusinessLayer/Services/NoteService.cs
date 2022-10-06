using NotesApplication.BusinessLayer.Interfaces;
using NotesApplication.BusinessLayer.Services.Repository;
using NotesApplication.BusinessLayer.ViewModels;
using NotesApplication.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.BusinessLayer.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task<Note> AddNote(Note note)
        {
            throw new NotImplementedException();
        }

        public async Task<Note> DeleteNote(int noteId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            throw new NotImplementedException();
        }

        public async Task<Note> GetNoteById(int noteId)
        {
            throw new NotImplementedException();
        }

        public async Task<Note> UpdateNote(int noteId,string status)
        {
            throw new NotImplementedException();
        }
    }
}

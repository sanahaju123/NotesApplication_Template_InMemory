using NotesApplication.BusinessLayer.ViewModels;
using NotesApplication.DataLayer;
using NotesApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.BusinessLayer.Services.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly NotesDbContext _noteDbContext;
        public NoteRepository(NotesDbContext notesDbContext)
        {
            _noteDbContext = notesDbContext;
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

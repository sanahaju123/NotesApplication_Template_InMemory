using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesApplication.BusinessLayer.Interfaces;
using NotesApplication.BusinessLayer.ViewModels;
using NotesApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApplication.Controllers
{
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

       /// <summary>
       /// Add Note By Id
       /// </summary>
       /// <param name="model"></param>
       /// <returns></returns>
        [HttpPost]
        [Route("/noteservice/add")]
        [AllowAnonymous]
        public async Task<IActionResult> AddNote([FromBody] NoteViewModel model)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// Update Note By Id
        /// </summary>
        /// <param name="noteId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("/noteservice/update/{noteId}/{status}")]
        public async Task<IActionResult> UpdateNote(int noteId,string status)
        {
            throw new NotImplementedException();
        }


       /// <summary>
       /// Delete Note By Id
       /// </summary>
       /// <param name="noteId"></param>
       /// <returns></returns>
        [HttpDelete]
        [Route("/noteservice/delete/{noteId}")]
        public async Task<IActionResult> DeleteNote(int noteId)
        {
            throw new NotImplementedException();
        }

       /// <summary>
       /// Get Note By Note Id
       /// </summary>
       /// <param name="noteId"></param>
       /// <returns></returns>
        [HttpGet]
        [Route("/noteservice/get/{noteId}")]
        public async Task<IActionResult> GetNoteById(int noteId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get List of All Notes.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/noteservice/all")]
        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            throw new NotImplementedException();
        }       
    }
}

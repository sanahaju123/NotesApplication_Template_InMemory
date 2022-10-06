﻿using Moq;
using NotesApplication.BusinessLayer.Interfaces;
using NotesApplication.BusinessLayer.Services;
using NotesApplication.BusinessLayer.Services.Repository;
using NotesApplication.BusinessLayer.ViewModels;
using NotesApplication.DataLayer;
using NotesApplication.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace NotesApplication.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly INoteService _noteServices;      
        public readonly Mock<INoteRepository> noteservice = new Mock<INoteRepository>();
        private readonly Note _note;
        private static string type = "Functional";
        public FunctionalTests(ITestOutputHelper output)
        {
            _noteServices = new NoteService(noteservice.Object);
            _output = output;

            _note = new Note
            {
                NoteId = 1,
                Description = "MyNote",
                Author = "MyAuthor",
                Status = "Completed",
                Title = "MyTitle",
            };
        }
        
        /// <summary>
        /// Test to Add a new Note.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Add_Note()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                noteservice.Setup(repos => repos.AddNote(_note)).ReturnsAsync(_note);
                var result = await _noteServices.AddNote(_note);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to Update a Note by Note Id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Update_Note()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            var _updateNote = new NoteViewModel()
            {
                NoteId = 1,
                Author = "NoteAuthor",
                Description = "NoteDescription",
                Title = "NoteTitle",
                Status ="Pending",
            };
            //Act
            try
            {
                noteservice.Setup(repos => repos.UpdateNote(_updateNote.NoteId,_updateNote.Status)).ReturnsAsync(_note);
                var result = await _noteServices.UpdateNote(_updateNote.NoteId, _updateNote.Status);
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");

            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to Get all Notes
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetAll_Notes()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                noteservice.Setup(repos => repos.GetAllNotes());
                var result = await _noteServices.GetAllNotes();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        /// <summary>
        /// Test to get Note By Id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetNoteById()
        {
            //Arrange
            var res = false;
            int noteId = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                noteservice.Setup(repos => repos.GetNoteById(noteId)).ReturnsAsync(_note);
                var result = await _noteServices.GetNoteById(noteId);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

       /// <summary>
       /// Delete Note By Id
       /// </summary>
       /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_DeleteNoteById()
        {
            //Arrange
            var res = false;
            int noteId = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Action
            try
            {
                noteservice.Setup(repos => repos.DeleteNote(noteId)).ReturnsAsync(_note);
                var result = await _noteServices.DeleteNote(noteId);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
    }
}

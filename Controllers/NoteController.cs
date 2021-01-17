using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes_App.Entities;
using Notes_App.IServices;
using Notes_App.Helpers;

namespace Notes_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        // GET: api/<NoteController>
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_noteService.GetAll());
        }

        // GET api/<NoteController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_noteService.Get(id));
        }

        // POST api/<NoteController>
        [HttpPost]
        public IActionResult Create(Note note)
        {
            var result = _noteService.Create(note);
            return Ok(result);
        }

        // PUT api/<NoteController>
        [HttpPut]
        public IActionResult Update(Note note)
        {
            return Ok(_noteService.Update(note));
        }

        // DELETE api/<NoteController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_noteService.Delete(id));
        }
    }
}

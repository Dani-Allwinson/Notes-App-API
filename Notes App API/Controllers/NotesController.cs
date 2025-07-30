
using Microsoft.AspNetCore.Mvc;
using Notes.Models.DTO;
using Notes.Models.Models;
using Notes.Repository.Interface;

namespace Notes_App_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INotesTagsService _service;
        public NotesController(INotesTagsService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetNotes()
        {
            var result = await _service.GetAllNotes();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddNotes(NotesDTO notesDTO)
        {
            await _service.AddNotesAsync(notesDTO);
            return NoContent();
        }

        [HttpGet("tag")]
        public async Task<IActionResult> GetNotesByTags(string tag)
        {
            var result = await _service.GetNotesTags(tag);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AddNotesToArchive([FromRoute]int id)
        {
            var result = await _service.AddNotesToArchive(id);

            if (result)
            {
                return Ok(result);
            } else
            {
                return NotFound();
            }
        }
    }
}

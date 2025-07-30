using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Notes.Models.DTO;
using Notes.Models.Models;
using Notes.Repository.Interface;

namespace Notes.Repository.ProcedureValidation
{
    public class NotesTagsService : INotesTagsService
    {
        private readonly NotesDBContext _context;
           
        public NotesTagsService(NotesDBContext context)
        {
            _context = context;
        }

        public async Task<List<NotesDTO>> GetAllNotes()
        {
            var result = _context.Notes.ToList();
            var taggedNotes = result.Select(x => new NotesDTO
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Content,
                Is_Archived = x.Is_Archived,
                Tags = x.Tags,
                Updated_By = x.Updated_By
            }).ToList();
            return await Task.FromResult(taggedNotes);
        }

        public async  Task<List<NotesDTO>> GetNotesTags(string tag)
        {
           List<NotesEntity> result =  _context.Notes.FromSqlRaw("EXEC GetTaggedNotes @tag", new SqlParameter("@tag", tag)).ToList();

            var taggedNotes = result.Select(x => new NotesDTO
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Content,
                Is_Archived = x.Is_Archived,
                Tags = x.Tags,
                Updated_By = x.Updated_By
            }).ToList();

            return await Task.FromResult(taggedNotes);
        }

        public async Task<bool> AddNotesToArchive(int id)
        {
            var selectedNote = await _context.Notes.FirstOrDefaultAsync(x => x.Id == id);

            if (selectedNote == null)
                return false;

            selectedNote.Is_Archived = true;
            selectedNote.Last_Updated = DateTime.Now;

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task AddNotesAsync(NotesDTO notesDTO)
        {
            NotesEntity notes = new()
            {
                Title = notesDTO.Title,
                Content = notesDTO.Content,
                Updated_By = notesDTO.Updated_By,
                Tags = notesDTO.Tags
            };

            await _context.Notes.AddAsync(notes);
        }
    }
}

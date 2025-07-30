using Notes.Models.DTO;

namespace Notes.Repository.Interface
{
    public interface INotesTagsService
    {
        Task<List<NotesDTO>> GetNotesTags(string tag);
        Task<List<NotesDTO>> GetAllNotes();
        Task<bool> AddNotesToArchive(int id);
        Task AddNotesAsync(NotesDTO notesDTO);
    }
}

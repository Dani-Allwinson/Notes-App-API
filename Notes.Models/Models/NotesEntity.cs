namespace Notes.Models.Models
{
    public class NotesEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public bool Is_Archived { get; set; }
        public string Tags { get; set; } = string.Empty;
        public DateTime Last_Updated { get; set; }
        public string Updated_By { get; set; } = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models.DTO
{
    public class NotesDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Updated_By { get; set; } = string.Empty;
        public bool Is_Archived { get; set; }
        public string Tags { get; set; } = string.Empty;


    }
}

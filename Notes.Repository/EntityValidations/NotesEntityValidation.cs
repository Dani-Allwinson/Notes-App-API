using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.Models.Models;

namespace Notes.Repository.EntityValidations
{
    public static class NotesEntityValidation
    {
        public static void ValidateNotesEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notes.Models.Models.NotesEntity>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Notes.Models.Models.NotesEntity>((o) =>
            {
                EntityTypeBuilder entity = o.ToTable("Notes");

                entity.Property(nameof(Notes.Models.Models.NotesEntity.Id)).HasColumnName("id");
                entity.Property(nameof(Notes.Models.Models.NotesEntity.Title)).HasColumnName("title");
                entity.Property(nameof(Notes.Models.Models.NotesEntity.Content)).HasColumnName("content");
                entity.Property(nameof(Notes.Models.Models.NotesEntity.Is_Archived)).HasColumnName("isArchived");
                entity.Property(nameof(Notes.Models.Models.NotesEntity.Tags)).HasColumnName("tags");
                entity.Property(nameof(Notes.Models.Models.NotesEntity.Last_Updated)).HasColumnName("last_updated").HasColumnType("datetime2");
                entity.Property(nameof(Notes.Models.Models.NotesEntity.Updated_By)).HasColumnName("updated_by");
            });
        }
    }
}

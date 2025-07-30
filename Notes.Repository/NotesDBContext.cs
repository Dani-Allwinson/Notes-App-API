using Microsoft.EntityFrameworkCore;
using Notes.Repository.EntityValidations;

namespace Notes.Repository
{
    public class NotesDBContext : DbContext
    {
        public NotesDBContext(DbContextOptions<NotesDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ValidateNotesEntity();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Notes.Models.Models.NotesEntity> Notes { get; set; }
    }
}

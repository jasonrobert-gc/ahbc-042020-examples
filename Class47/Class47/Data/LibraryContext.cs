using Class47.Models;
using Microsoft.EntityFrameworkCore;

namespace Class47.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(x => x.FirstName)
                    .HasMaxLength(50)
                    .IsRequired();

            modelBuilder.Entity<Author>()
                .Property(x => x.LastName)
                    .HasMaxLength(50)
                    .IsRequired();
        }
    }
}

using Class45_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Class45_EF.Data
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
            modelBuilder.Entity<Book>().ToTable("Book")
                .Property(x => x.Genre)
                    .HasMaxLength(50)
                    .IsRequired();

            modelBuilder.Entity<Author>()
                .Property(x => x.LastName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("VARCHAR");
        }
    }
}

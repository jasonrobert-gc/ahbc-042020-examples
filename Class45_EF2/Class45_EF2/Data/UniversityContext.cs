using Class45_EF2.Models;
using Microsoft.EntityFrameworkCore;

namespace Class45_EF2.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {
                
        }

        public DbSet<Student> Students { get; set; }
    }
}

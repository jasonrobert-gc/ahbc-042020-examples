using AssessmentPrep6.Models;
using Microsoft.EntityFrameworkCore;

namespace AssessmentPrep6.Data
{
    public class ClassDbContext : DbContext
    {
        public ClassDbContext(DbContextOptions<ClassDbContext> options) : base(options)
        {

        }

        public DbSet<Assessment> Assessments { get; set; }
    }
}

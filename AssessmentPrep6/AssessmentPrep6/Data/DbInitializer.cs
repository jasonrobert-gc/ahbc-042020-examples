using System;
using System.Linq;

namespace AssessmentPrep6.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClassDbContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Assessments.Any())
            {
                context.Assessments.Add(new Models.Assessment() { Name = "Assessment 6", Points = 10, Date = DateTime.Parse("8/10/2020")});
                context.SaveChanges();
            }
        }
    }
}

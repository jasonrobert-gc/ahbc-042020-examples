using Class45_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class45_EF.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Books.Any())
            {
                context.Books.Add(new Book() { Title = "Harry Potter and the Sorcerer's Stone", Genre = "Fantasy", ReleaseDate = DateTime.Parse("6/14/1997") });
                context.Books.Add(new Book() { Title = "A Tale of Two Cities", Genre = "Fiction", ReleaseDate = DateTime.Parse("12/25/1859") });
                context.SaveChanges();
            }
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Class45_EF.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }
    }
}

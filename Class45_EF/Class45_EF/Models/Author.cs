using System.ComponentModel.DataAnnotations;

namespace Class45_EF.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }
    }
}

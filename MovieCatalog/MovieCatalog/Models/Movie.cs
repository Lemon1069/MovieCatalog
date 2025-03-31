using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int Year { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }
    }
}

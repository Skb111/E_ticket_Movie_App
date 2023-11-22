using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace example.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public String? ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 to 20 chars")]
        public String? FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public String? Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        public Cinema? Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        public Producer? Producer { get; set; }
    }
}

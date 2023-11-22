using System.ComponentModel.DataAnnotations;

namespace example.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public String? ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public String? FullName { get; set; }
        [Display(Name = "Biography")]
        public String? Bio { get; set; }

        public List<Movie>? Movies { get; set; }
    }
}

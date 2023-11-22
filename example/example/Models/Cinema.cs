using System.ComponentModel.DataAnnotations;

namespace example.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public String? Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public String? Name { get; set; }
        [Display(Name="Description")]
        public String? Description { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }
    }
}

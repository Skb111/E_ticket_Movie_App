using example.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace example.Models
{
    public class Movie
    {
        
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public String? Name { get; set; }
        [Display(Name="Description")]
        public String? Description { get; set; }
        public double Price { get; set; }
        [Display(Name = "ImageURL")]
        public String? ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        

        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }
        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }
    }
}

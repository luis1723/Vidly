using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        
        public Genre Genre { get; set; }

        [Display(Name = "Genero")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Dia De Lanzamiento")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name ="Numero En Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

    }
}
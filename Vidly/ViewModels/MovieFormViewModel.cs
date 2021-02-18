using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        
        public int? Id { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name ="Genero")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Dia De Lanzamiento")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name= "Numero En Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {

                return Id != 0 ? "Edit Movie" : "New Movie";

            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}
namespace eTickets.Data.Entities
{
    using eTickets.Data.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static eTickets.Data.DataConstants.DataConstants.Movie;
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; }

        [Required]
        [Range(MinPrice, MaxPrice)]
        [Column(TypeName = "decimal(18,2)")]
        public double Price { get; set; }

        [Required]
        [MaxLength(ImageURLMaxLength)]
        [Url]
        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }

        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
    }
}

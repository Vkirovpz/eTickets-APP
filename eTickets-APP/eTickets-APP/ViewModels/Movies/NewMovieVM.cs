namespace eTickets_APP.ViewModels.Movies
{
    using eTickets.Data.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static eTickets.Data.DataConstants.DataConstants.Movie;
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie name")]
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Display(Name = "Movie description")]
        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required]
        [Range(MinPrice, MaxPrice)]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required]
        [MaxLength(ImageURLMaxLength)]
        [Url]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end date")]
        [Required]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required]
        public MovieCategory MovieCategory { get; set; }

        [Display(Name = "Select actors(s)")]
        [Required]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a cinema")]
        [Required]
        public int CinemaId { get; set; }

        [Display(Name = "Select a producer")]
        [Required]
        public int ProducerId { get; set; }
    }
}

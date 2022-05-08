namespace eTickets.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static eTickets.Data.DataConstants.DataConstants.Cinema;
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(LogoURLMaxLength)]
        [Url]
        public string Logo { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}

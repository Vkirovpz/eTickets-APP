namespace eTickets.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static eTickets.Data.DataConstants.DataConstants.Cinema;
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(LogoURLMaxLength)]
        [Url]
        [Display(Name = "Cinema logo")]
        public string Logo { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}

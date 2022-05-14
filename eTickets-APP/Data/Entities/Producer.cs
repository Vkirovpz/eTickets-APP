namespace eTickets.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static eTickets.Data.DataConstants.DataConstants.Producer;
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(FullNameMaxLength, MinimumLength = FullNameMinLength)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [MaxLength(ProfilePictureURLMaxLength)]
        [Url]
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Required]
        [StringLength(BioMaxLength, MinimumLength = BioMinLength)]
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}

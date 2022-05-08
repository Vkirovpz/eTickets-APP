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
        public string FullName { get; set; }

        [Required]
        [MaxLength(ProfilePictureURLMaxLength)]
        [Url]
        public string ProfilePictureURL { get; set; }

        [Required]
        [StringLength(BioMaxLength, MinimumLength = BioMinLength)]
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}

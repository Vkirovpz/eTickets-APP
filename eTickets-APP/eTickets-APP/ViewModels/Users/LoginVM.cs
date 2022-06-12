namespace eTickets_APP.ViewModels.Users
{
    using System.ComponentModel.DataAnnotations;
    public class LoginVM
    {
        [Display(Name ="Email address")]
        [Required(ErrorMessage ="Email address is required")]
        public string EmailAddress { get; set; }

       
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

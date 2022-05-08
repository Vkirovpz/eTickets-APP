namespace eTickets.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ProfilePictureURL { get; set; }
        public int Bio { get; set; }
    }
}

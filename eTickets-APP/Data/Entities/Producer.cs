namespace eTickets.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ProfilePictureURL { get; set; }
        public int Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}

namespace eTickets.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Actor_Movie
    {
        [Required]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}

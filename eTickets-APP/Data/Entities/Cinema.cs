namespace eTickets.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

namespace eTickets.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class ShoppingCartItem : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public Movie Movie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}

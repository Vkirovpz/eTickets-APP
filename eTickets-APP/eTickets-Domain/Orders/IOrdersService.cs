namespace eTickets_Domain.Orders
{
    using eTickets.Data.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IOrdersService
    {
        Task StoreOrderAsync (List<ShoppingCartItem> items, string userId, string userEmailAdress);

        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}

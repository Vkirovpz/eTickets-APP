namespace eTickets_APP.Controllers
{
    using eTickets_APP.ViewModels.Cart;
    using eTickets_Domain.Cart;
    using eTickets_Domain.Movies;
    using Microsoft.AspNetCore.Mvc;
    public class OrdersController : Controller
    {
        private readonly IMoviesService _movies;
        private readonly ShoppingCart _shoppingCart;

        public OrdersController(IMoviesService movies, ShoppingCart shoppingCart)
        {
            _movies = movies;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        { 
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
    }
}

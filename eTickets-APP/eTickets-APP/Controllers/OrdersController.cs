﻿namespace eTickets_APP.Controllers
{
    using eTickets_APP.ViewModels.Cart;
    //using eTickets_Domain.Cart;
    using eTickets_App.Cart;
    using eTickets_Domain.Movies;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using eTickets_Domain.Orders;

    public class OrdersController : Controller
    {
        private readonly IMoviesService _movies;
        private readonly IOrdersService _ordersService;
        private readonly ShoppingCart _shoppingCart;

        public OrdersController(IMoviesService movies, ShoppingCart shoppingCart, IOrdersService ordersService)
        {
            _movies = movies;
            _ordersService = ordersService;
            _shoppingCart = shoppingCart;
        }

        public async Task<IActionResult> Index()
        {
            string userId = "";
            var orders = await _ordersService.GetOrdersByUserIdAsync(userId);
            return View(orders);
        }

        public IActionResult ShoppingCart()
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

        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _movies.GetMovieByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

       public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _movies.GetMovieByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = "";
            string userEmailAdress = "";

           await _ordersService.StoreOrderAsync(items, userId, userEmailAdress);
           await _shoppingCart.ClearShoppingCartAsync();

            return View("OrderCopmpleted");
        }


    }
}

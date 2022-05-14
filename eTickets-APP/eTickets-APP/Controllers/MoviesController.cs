namespace eTickets_APP.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

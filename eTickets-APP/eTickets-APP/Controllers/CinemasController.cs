namespace eTickets_APP.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    public class CinemasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

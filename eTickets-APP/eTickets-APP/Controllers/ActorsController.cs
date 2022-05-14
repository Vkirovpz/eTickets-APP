namespace eTickets_APP.Controllers
{
    using eTickets_Domain.Actors;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class ActorsController : Controller
    {
        private readonly  IActorsService _actors;

        public ActorsController(IActorsService actors)
        {
            _actors = actors;
        }

        public async Task<IActionResult> Index()
        {
            var allActors = await _actors.GetAll();
            return View(allActors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //public async Task<IActionResult> Create()
        //{
        //    return View();
        //}
    }
}

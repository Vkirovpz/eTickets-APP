namespace eTickets_APP.Controllers
{
    using eTickets.Data.Entities;
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
            var allActors = await _actors.GetAllAsync();
            return View(allActors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);              
            }
            await _actors.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actors.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("Empty");
            }

            return View(actorDetails);
        }
    }
}

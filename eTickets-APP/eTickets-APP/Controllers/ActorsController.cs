namespace eTickets_APP.Controllers
{
    using eTickets.Data.Entities;
    using eTickets_Domain.Actors;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Authorize]
    public class ActorsController : Controller
    {
        private readonly  IActorsService _actors;

        public ActorsController(IActorsService actors)
        {
            _actors = actors;
        }

        [AllowAnonymous]
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

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actors.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _actors.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");

            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actors.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actors.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");

            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _actors.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");

            await _actors.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}

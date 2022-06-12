namespace eTickets_APP.Controllers
{
    using eTickets.Data.Entities;
    using eTickets.Data.Static;
    using eTickets_Domain.Producers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Authorize(Roles = UserRoles.Admin)]
    public class ProducersController : Controller
    {
        private readonly IProducersService _producers;

        public ProducersController(IProducersService producers)
        {
            _producers = producers;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allProducers = await _producers.GetAllAsync();
            return View(allProducers);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _producers.GetByIdAsync(id);

            if (producerDetails == null) return View("NotFound");

            return View(producerDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var producer = await _producers.GetByIdAsync(id);

            if (producer == null) return View("NotFound");

            return View(producer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _producers.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var producer = await _producers.GetByIdAsync(id);

            if (producer == null) return View("NotFound");

            return View(producer);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producer = await _producers.GetByIdAsync(id);

            if (producer == null) return View("NotFound");

            await _producers.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _producers.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }
    }
}

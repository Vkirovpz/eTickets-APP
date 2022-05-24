namespace eTickets_APP.Controllers
{
    using eTickets.Data.Entities;
    using eTickets_Domain.Cinemas;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class CinemasController : Controller
    {
        private readonly ICinemasService _cinemas;

        public CinemasController(ICinemasService cinemas)
        {
            _cinemas = cinemas;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _cinemas.GetAllAsync();
            return View(allCinemas);
        }

        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _cinemas.GetByIdAsync(id);

            if (cinemaDetails == null) return View("NotFound");

            return View(cinemaDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var cinema = await _cinemas.GetByIdAsync(id);

            if (cinema == null) return View("NotFound");

            return View(cinema);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _cinemas.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var cinema = await _cinemas.GetByIdAsync(id);

            if (cinema == null) return View("NotFound");

            return View(cinema);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinema = await _cinemas.GetByIdAsync(id);

            if (cinema == null) return View("NotFound");

            await _cinemas.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _cinemas.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }
    }
}

namespace eTickets_APP.Controllers
{
    using eTickets.Data.Entities;
    using eTickets_Domain.Producers;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class ProducersController : Controller
    {
        private readonly IProducersService _producers;

        public ProducersController(IProducersService producers)
        {
            _producers = producers;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _producers.GetAllAsync();
            return View(allProducers);
        }

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _producers.GetByIdAsync(id);

            if (producerDetails == null) return View("NotFound");

            return View(producerDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _producers.GetByIdAsync(id);

            if (producerDetails == null) return View("NotFound");

            return View(producerDetails);
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
            var producerDetails = await _producers.GetByIdAsync(id);

            if (producerDetails == null) return View("NotFound");

            return View(producerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _producers.GetByIdAsync(id);

            if (producerDetails == null) return View("NotFound");

            await _producers.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}

namespace eTickets_APP.Controllers
{
    using eTickets_Domain.Movies;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Threading.Tasks;

    public class MoviesController : Controller
    {
        private readonly IMoviesService _movies;

        public MoviesController(IMoviesService movies)
        {
            _movies = movies;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _movies.GetAllAsync(n=> n.Cinema);
            return View(allMovies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _movies.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _movies.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
            return View();
        }
    }
}

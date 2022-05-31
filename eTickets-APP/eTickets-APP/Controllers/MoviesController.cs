namespace eTickets_APP.Controllers
{
    using eTickets_Domain.Movies;
    using Microsoft.AspNetCore.Mvc;
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
    }
}

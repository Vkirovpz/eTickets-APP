namespace eTickets_APP.Controllers
{
    using eTickets_APP.ViewModels.Movies;
    using eTickets_Domain.Movies;
    using eTickets_Domain.Movies.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Linq;
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
            var allMovies = await _movies.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _movies.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _movies.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM movie)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _movies.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

                return View(movie);
            }
            var movieToAdd = new NewMovieSM()
            {
                Name = movie.Name,
                Description = movie.Description,
                Price = movie.Price,
                ImageURL = movie.ImageURL,
                StartDate = movie.StartDate,
                EndDate = movie.EndDate,
                MovieCategory = movie.MovieCategory,
                ActorIds = movie.ActorIds,
                CinemaId = movie.CinemaId,
                ProducerId = movie.ProducerId,
            };

            await _movies.AddNewMovieAsync(movieToAdd);

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var movieDetails = await _movies.GetMovieByIdAsync(id);
            if (movieDetails == null) return View("Not found");

            var response = new NewMovieVM()
            {
                Name = movieDetails.Name,
                Description = movieDetails.Description,
                Price = movieDetails.Price,
                ImageURL = movieDetails.ImageURL,
                StartDate = movieDetails.StartDate,
                EndDate = movieDetails.EndDate,
                MovieCategory = movieDetails.MovieCategory,
                ActorIds = movieDetails.Actors_Movies.Select(n => n.ActorId).ToList(),
                CinemaId = movieDetails.CinemaId,
                ProducerId = movieDetails.ProducerId,
            };
            var movieDropdownsData = await _movies.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewMovieVM movie)
        {
            if (id != movie.Id) return View("Not found");

            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _movies.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

                return View(movie);
            }
            var movieToAdd = new NewMovieSM()
            {
                Id = movie.Id,
                Name = movie.Name,
                Description = movie.Description,
                Price = movie.Price,
                ImageURL = movie.ImageURL,
                StartDate = movie.StartDate,
                EndDate = movie.EndDate,
                MovieCategory = movie.MovieCategory,
                ActorIds = movie.ActorIds,
                CinemaId = movie.CinemaId,
                ProducerId = movie.ProducerId,
            };

            await _movies.UpdateMovieAsync(movieToAdd);

            return RedirectToAction(nameof(Index));
        }
    }
}

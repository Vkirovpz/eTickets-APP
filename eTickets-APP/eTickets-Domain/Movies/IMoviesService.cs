namespace eTickets_Domain.Movies
{
    using eTickets.Data.Entities;
    using eTickets_Domain.Base;
    using eTickets_Domain.Movies.Models;
    using System.Threading.Tasks;

    public interface IMoviesService: IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);

        Task<NewMovieDropdownsSM> GetNewMovieDropdownsValues();
    }
}

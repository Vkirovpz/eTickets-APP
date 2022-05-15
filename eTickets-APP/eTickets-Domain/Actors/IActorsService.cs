namespace eTickets_Domain.Actors
{
    using eTickets.Data.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();

        Task<Actor> GetByIdAsync(int id);

        Task AddAsync(Actor actor);

       Task<Actor> UpdateAsync(int id, Actor newActor);

        void Delete(int id);
    }
}

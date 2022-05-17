namespace eTickets_Domain.Actors
{
    using eTickets.Data;
    using eTickets.Data.Entities;
    using eTickets_Domain.Base;

    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}

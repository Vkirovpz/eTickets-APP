namespace eTickets_Domain.Producers
{
    using eTickets.Data;
    using eTickets.Data.Entities;
    using eTickets_Domain.Base;
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
    }
}

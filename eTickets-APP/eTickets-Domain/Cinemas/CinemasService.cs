namespace eTickets_Domain.Cinemas
{
    using eTickets.Data;
    using eTickets.Data.Entities;
    using eTickets_Domain.Base;
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) { }
    }
}

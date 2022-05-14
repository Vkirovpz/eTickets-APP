namespace eTickets_Domain.Actors
{
    using eTickets.Data;
    public class ActorsService
    {
        private readonly AppDbContext data;

        public ActorsService(AppDbContext data)
        {
            this.data = data;
        }
    }
}

namespace eTickets.Data
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using System.Linq;

    public class AppDbInitializer
    {
        public static void Seed (IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {

                }

                if (!context.Actors.Any())
                {

                }

                if (!context.Producers.Any())
                {

                }

                if (!context.Movies.Any())
                {

                }

                if (!context.Actors_Movies.Any())
                {

                }
            }
        }
    }
}

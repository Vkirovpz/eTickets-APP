namespace eTickets_Domain.Movies.Models
{
    using System.Collections.Generic;
    using eTickets.Data.Entities;
    public class NewMovieDropdownsSM
    {
        public NewMovieDropdownsSM()
        {
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
        }
        public List<Producer> Producers { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }
    }
}

namespace eTickets_Domain.Movies.Models
{
    using eTickets.Data.Enums;
    using System;
    using System.Collections.Generic;
    public class NewMovieSM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public List<int> ActorIds { get; set; }
        public int CinemaId { get; set; }
        public int ProducerId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickedBookingApp.Models
{
    public class Theatre
    {
        public Theatre(string name) {
            this.Movies = new List<Movie>();
            this.Auditoriums = new List<Auditorium>();
            this.Name = name;
            this.Shows = new List<Show>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Auditorium> Auditoriums { get; set; }

        public List<Show> Shows { get; set; }

        public List<Movie> Movies { get; set; }

        public string City { get; set; }

        public void SetTheatreId(int id)
        {
            this.Id = id;
        }

        public void SetMovies(List<Movie> movies)
        {
            this.Movies.AddRange(movies);
        }

        public void SetShows(List<Show> shows)
        {
            this.Shows.AddRange(shows);
        }

        public void SetAuditoriums(List<Auditorium> auditoriums)
        {
            this.Auditoriums.AddRange(auditoriums);
        }

        public void SetCity(string city)
        {
            this.City = city;
        }
    }
}

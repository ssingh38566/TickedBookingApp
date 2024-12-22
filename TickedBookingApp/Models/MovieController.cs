using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickedBookingApp.Models
{
    public class MovieController
    {
        public MovieController() {
            this.Movies = new List<Movie>();
            this.MoviesByCities = new Dictionary<string, List<Movie>>();
        }
        public List<Movie> Movies { get; set; }

        public Dictionary<string, List<Movie>> MoviesByCities { get; set; }

        public void AddMovie(string city, Movie movie) { 
            this.Movies.Add(movie);
            if (!this.MoviesByCities.ContainsKey(city)) { 
                this.MoviesByCities[city] = new List<Movie>();
            }

            this.MoviesByCities[city].Add(movie);
        }

        public List<Movie> GetMoviesByCity(string city)
        {
            return this.MoviesByCities[city];
        }
        

        public Movie? GetMovieByName(string movieName)
        {
            Movie? foundMovie = null;
            foreach (var movie in this.Movies)
            {
                if (movie.Title == movieName)
                {
                    foundMovie = movie;
                    break;
                }
            }

            return foundMovie;
        }
    }
}

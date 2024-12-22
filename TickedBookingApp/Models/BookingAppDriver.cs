using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickedBookingApp.Models
{
    public class BookingAppDriver
    {
        public BookingAppDriver() {
            this.movieController = new MovieController();
            this.theatreController = new TheatreController();
        }
        private TheatreController theatreController { get; set; }
        private MovieController movieController { get; set; }

        public void Initialize()
        {
           this.CreateMovies();
           this.CreateTheatres();
        }

        public Booking? CreateBooking(string city, string movieName)
        {
            if (this.movieController.GetMovieByName(movieName) == null) {
                return null;
            }

            var theatres = this.theatreController.GetTheatresByCity(city);


            foreach (var theatre in theatres)
            {
                if (theatre.Shows.Any(x => x.Movie.Title == movieName))
                {
                    var show = theatre.Shows.FirstOrDefault(x => x.Movie.Title == movieName);
                    var booking = new Booking();
                    Console.WriteLine("Movie booked successfully, Your show starts at " + show.StartTime);
                    return booking;
                }
            }

            return null;
        }

        private void CreateMovies()
        {
            List<Movie> movies = new List<Movie>();

            var bahubali = new Movie(1, "Bahubali", 180);
            var spiderMan = new Movie(2, "Spiderman - Homecoming", 144);


            movieController.AddMovie("Raipur", spiderMan);
            movieController.AddMovie("Raipur", bahubali);
            movieController.AddMovie("Bilaspur", bahubali);
            movieController.AddMovie("Ambikapur", bahubali);
        }

        private void CreateTheatres()
        {
            var pvr = new Theatre("PVR");   
            var inox = new Theatre("Inox");

            pvr.SetCity("Raipur");
            inox.SetCity("Raipur");


            var bahubali = this.movieController.GetMovieByName("Bahubali");
            var spiderMan = this.movieController.GetMovieByName("Spiderman - Homecoming");
            var auditorium = CreateAuditorium();

            pvr.SetAuditoriums(new List<Auditorium>() { auditorium });
            inox.SetAuditoriums(new List<Auditorium>() { auditorium });


            var bahubaliShow = new Show(DateTime.Now.AddDays(1), bahubali, pvr.Auditoriums.FirstOrDefault());
            var spiderManShow = new Show(DateTime.Now.AddDays(1), spiderMan, pvr.Auditoriums.FirstOrDefault());

            pvr.SetShows(new List<Show>() { bahubaliShow });
            inox.SetShows(new List<Show>() { spiderManShow });

            this.theatreController.AddTheatre(pvr.City, pvr);
            this.theatreController.AddTheatre(inox.City, inox);
        }


        public Auditorium CreateAuditorium()
        {
            var auditorium = new Auditorium();
            List<Seat> seats = new List<Seat>();

            for (int i = 0; i < 100; i++)
            {
                var seat = new Seat(i);
                seats.Add(seat);
            }

            auditorium.SetSeats(seats);
            auditorium.SetAuditoriumId(1);
            return auditorium;
        }
    }
}

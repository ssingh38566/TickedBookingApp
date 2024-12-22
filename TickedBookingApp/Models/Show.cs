using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickedBookingApp.Models
{
    public class Show
    {
        public Show (DateTime start, Movie movie, Auditorium auditorium)
        {
            StartTime = start;
            Movie = movie;
            Auditorium = auditorium;
        }

        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public Movie Movie { get; set; }

        public Auditorium Auditorium { get; set; }
    }
}

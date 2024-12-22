using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickedBookingApp.Models
{
    public class Movie
    {
        public Movie(int _id, string _title, int _duration) {
            Id = _id;
            Title = _title;
            Duration = _duration;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public int Duration { get; set; }
    }
}

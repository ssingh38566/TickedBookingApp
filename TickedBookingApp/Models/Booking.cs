using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickedBookingApp.Models
{
    public class Booking
    {
        public Booking() {
            this.BookedSeats = new List<Seat>();
        }
        public int Id { get; set; }

        public Payment? Payment { get; set; }

        public DateTime BookingDate { get; set; }

        public List<Seat> BookedSeats { get; set; }
    }
}

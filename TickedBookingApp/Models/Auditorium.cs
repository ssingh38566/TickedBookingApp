using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickedBookingApp.Models
{
    public class Auditorium
    {
        public Auditorium() {
            this.Seats = new List<Seat>();
        }
        public int Id { get; set; }

        public List<Seat> Seats { get; set; }

        public void SetAuditoriumId(int id)
        {
            this.Id = id;
        }

        public int GetAuditoriumId()
        {
            return this.Id;
        }

        public void SetSeats(List<Seat> seats)
        {
            this.Seats = seats;
        }

        public List<Seat> GetSeats()
        {
            return this.Seats;
        }
    }
}

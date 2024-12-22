using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickedBookingApp.Models
{
    public class Seat
    {
        public Seat(int id)
        {
            this.Id = id;
            this.IsBooked = false;
        }
        public int Id { get; set; }

        public int Row { get; set; }

        public bool IsBooked { get; set; }

        public void MarkBooked()
        {
            this.IsBooked = true;
        }
    }
}

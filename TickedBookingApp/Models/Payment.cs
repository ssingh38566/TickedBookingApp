using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickedBookingApp.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public string PaymentType { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}

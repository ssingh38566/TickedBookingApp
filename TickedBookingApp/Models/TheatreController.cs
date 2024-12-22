using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickedBookingApp.Models
{
    public class TheatreController
    {
        public TheatreController() {
            this.Theatres = new List<Theatre>();
            this.TheatresByCities = new Dictionary<string, List<Theatre>>();
        }
        public List<Theatre> Theatres { get; set; }

        public Dictionary<string, List<Theatre>> TheatresByCities { get; set; }

        public void AddTheatre(string city, Theatre theatre) { 
            this.Theatres.Add(theatre);
            if (!this.TheatresByCities.ContainsKey(city)) { 
                this.TheatresByCities[city] = new List<Theatre>();
            }

            this.TheatresByCities[city].Add(theatre);
        }

        public List<Theatre> GetTheatresByCity(string city)
        {
            return this.TheatresByCities[city];
        }
    }
}

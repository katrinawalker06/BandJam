using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandJam.Models
{
    public class Reservation
    {
        public DateTime ReservationTime { get; set; }
        public string ReservationTitle { get; set; }
        public virtual Band Band { get; set; }
    }
}

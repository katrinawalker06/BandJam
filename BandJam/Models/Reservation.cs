using BandJam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandJam.Models
{
    public class Reservation
    {   
        public int Id { get; set; }
        public DateTime ReservationTime { get; set; }
        public string Location { get; set; }
        public string ReservationTitle { get; set; }
        public virtual Band Band { get; set; }
    }
}
       
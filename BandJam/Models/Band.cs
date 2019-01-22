using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandJam.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string BandName { get; set; }
        public string RequestId { get; set; }
        public string Genre { get; set; }
        public int  BandSize  { get; set; }
        public string Experience { get; set; }
        public string Bio { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public virtual ICollection<BandMember> BandMembers { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}

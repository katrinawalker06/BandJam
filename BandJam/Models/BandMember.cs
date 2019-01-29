using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandJam.Models
{
    public class BandMember
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Instrument { get; set; }

        public string BandName { get; set; }

        public ICollection<BandMemberBand> BandMemberBands { get; set; }

        public virtual Band Band { get; set; } 

    }
}

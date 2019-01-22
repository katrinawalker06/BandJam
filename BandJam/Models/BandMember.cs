using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandJam.Models
{
    public class BandMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Instrument { get; set; }

        public virtual ICollection<Band> Bands { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandJam.Models
    {
        public class BandMemberBand
        {
            [Key]
            public int BandMemberBandId { get; set; }
            public int BandMemberId { get; set; }
            public BandMember BandMember { get; set; }
            public int BandId { get; set; }
            public Band Band { get; set; }
        }
    }


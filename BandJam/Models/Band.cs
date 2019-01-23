using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BandJam.Models
{   
    public class Band
    {
        
        [Required]
        public int Id { get; set; }
        [Required]
        public string BandName { get; set; }
        [Required]
        public string RequestId { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int  BandSize  { get; set; }
        [Required]
        public string Experience { get; set; }
        [Required]
        public string BandMembers{ get; set; }
        [Required]
        public string Bio { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        
       
        public virtual ICollection<Reservation> Reservations { get; set; }
        

    }
}

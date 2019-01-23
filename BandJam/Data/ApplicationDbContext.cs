using BandJam.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BandJam.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Band> Bands { get; set; }
        public DbSet<BandMember> BandMembers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<BandMemberBand> BandMemberBands { get; set; }


        
        //public DbSet<Band> Genre { get; set; }
        //public DbSet<Band> BandSize { get; set; }
        //public DbSet<Band> Experience { get; set; }
        //public DbSet<Band> Bio { get; set; }
        //public DbSet<Band> Email { get; set; }
    }
    }






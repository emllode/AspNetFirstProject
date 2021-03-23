using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorapp1.Models;

namespace razorapp1.Data
{
    public class razorapp1Context : DbContext
    {
        public razorapp1Context (DbContextOptions<razorapp1Context> op)
            : base(op)
        {
        }

        public DbSet<razorapp1.Models.Event> Event { get; set; }
        public DbSet<razorapp1.Models.Attendee> Attendee { get; set; }
        public DbSet<razorapp1.Models.Organizer> Organizer { get; set; }



        protected override void OnModelCreating(ModelBuilder mB)
        {
            mB.Entity<Attendee>().ToTable("Attendee");
            mB.Entity<Event>().ToTable("Event");
            mB.Entity<Organizer>().ToTable("Organizer");
        }

    }
}

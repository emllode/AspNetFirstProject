using Microsoft.EntityFrameworkCore;

namespace razorapp1.Data
{
    public class razorapp1Context : DbContext
    {
        public razorapp1Context (DbContextOptions<razorapp1Context> op)
            : base(op)
        {
        }

        public DbSet<razorapp1.Models.Event> Event { get; set; }
        public DbSet<razorapp1.Models.EventAttendee> EventAttendees { get; set; }
        public DbSet<razorapp1.Models.Attendee> Attendees { get; set; }
    }

}

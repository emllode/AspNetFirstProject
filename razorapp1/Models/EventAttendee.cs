using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorapp1.Models
{
    public class EventAttendee
    {
        public int EventAttendeeID { get; set; }
        public int EventID { get; set; }
        public int AttendeeID { get; set; }

        public Attendee Attendee { get; set; }
        public Event Event { get; set; }
    }
}

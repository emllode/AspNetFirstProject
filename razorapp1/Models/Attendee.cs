using System;
using System.Collections.Generic;


namespace razorapp1.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<EventAttendee> EventAttendees { get; set; }


    }

}

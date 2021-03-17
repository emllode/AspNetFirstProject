using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorapp1.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Event> Events { get; set; }


    }

}

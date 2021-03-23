using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorapp1.Data;
using razorapp1.Models;

namespace razorapp1.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly razorapp1.Data.razorapp1Context _context;


        public IList<EventAttendee> EventAttendee { get; set; }


        public MyEventsModel(razorapp1.Data.razorapp1Context context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            EventAttendee = await _context.EventAttendees.Include(e => e.Event).Include(e => e.Attendee).ToListAsync();

        }
    }

}

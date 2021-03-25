using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorapp1.Models;

namespace razorapp1.Pages
{
    public class MyEventsModel : PageModel
    {     
        public IList<EventAttendee> EventAttendee { get; set; }


        [TempData]
        public String Message { get; set; }

        public bool ShowMessage => !String.IsNullOrEmpty(Message);

        private readonly razorapp1.Data.razorapp1Context _context;




        public MyEventsModel(razorapp1.Data.razorapp1Context context)
        {
            _context = context;
        }
 
        public async Task OnGetAsync()
        {
            EventAttendee = await _context.EventAttendees.Include(e => e.Event).Include(e => e.Attendee).ToListAsync();

        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            _context.EventAttendees.Attach(new EventAttendee { EventAttendeeID = id }).State = EntityState.Deleted;
            await _context.SaveChangesAsync();

            Message = "You have now left the event!";

           return RedirectToPage();
        }


    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorapp1.Models;
using razorapp1.Data;


namespace razorapp1.Pages
{
    public class JoinEventsPageModel : PageModel
    {
        private readonly razorapp1.Data.razorapp1Context _context;
        public JoinEventsPageModel(razorapp1.Data.razorapp1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public EventAttendee EventAttendee { get; set; }

        public Event Event { get; set; }

        [TempData]
        public String Message { get; set; }

        public bool ShowMessage => !String.IsNullOrEmpty(Message);

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = _context.Event.Where(e => e.EventID == id).FirstOrDefault();

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD

        /* Vill fixa så man ser notifikation */
        public async Task<IActionResult> OnPostJoinAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EventAttendee.Attendee = _context.Attendees.Where(a => a.AttendeeID == 1).FirstOrDefault();
            EventAttendee.Event = _context.Event.Where(e => e.EventID == id).FirstOrDefault();

            _context.EventAttendees.Add(EventAttendee);


            await _context.SaveChangesAsync();

            Message = "The event has been added to your event-page!";

            return RedirectToPage();

        }
    }
}
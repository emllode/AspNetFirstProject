using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorapp1.Models;


namespace razorapp1.Pages
{
    public class JoinEventsPageModel : PageModel
    {
        [BindProperty]
        public EventAttendee EventAttendee { get; set; }

        public Event Event { get; set; }

        [TempData]
        public String Message { get; set; }

        public bool ShowMessage => !String.IsNullOrEmpty(Message);



        private readonly razorapp1.Data.razorapp1Context _context;
        public JoinEventsPageModel(razorapp1.Data.razorapp1Context context)
        {
            _context = context;
        }

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
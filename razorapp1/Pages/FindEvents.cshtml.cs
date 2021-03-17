using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using razorapp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorapp1.Pages
{
    public class FindEvent : PageModel
    {


        [BindProperty]
        public Models.Event NewAttendee { get; set; }



        private readonly razorapp1.Data.razorapp1Context _context;

        public FindEvent(razorapp1.Data.razorapp1Context context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.ToListAsync();
        }

        public void OnPost()
        {
            Event.Add(NewAttendee);
            _context.Event.Add(NewAttendee);
            _context.SaveChanges();
        }
    }
}

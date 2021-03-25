using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorapp1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace razorapp1.Pages
{
    public class FindEvent : PageModel
    {
        public IList<Event> Event { get; set; }


        private readonly razorapp1.Data.razorapp1Context _context;

        public FindEvent(razorapp1.Data.razorapp1Context context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.ToListAsync();
        }

 
    }
}

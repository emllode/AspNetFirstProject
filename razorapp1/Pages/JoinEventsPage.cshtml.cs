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

 
        public string Message  { get; set; }

        [BindProperty]
        public bool ShowMessage { get; set; }

        [BindProperty]
        public Event Event { get; set; }

        public void OnPostUpdateNotificationPreferences(int id)
        {
            if(ShowMessage)
            {
                Message = "Du är välkommen på eventet.";
            }
            else
            {
                Message = "Nope, you don't wanna go? :(";
            }

  
        }

       

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.EventID == id);

            if (Event == null)
            {
                return NotFound();
            }

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(Event.EventID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.EventID == id);
        }

        public  async Task<IActionResult> OnPostDeleteAsync()

        {
         
            Message = "IT WORKS!!";
            return RedirectToPage();


        }

    }
}

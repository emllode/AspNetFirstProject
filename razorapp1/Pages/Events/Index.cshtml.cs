﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorapp1.Data;
using razorapp1.Models;

namespace razorapp1.Pages.Events
{
    public class IndexModel : PageModel
    {
        private readonly razorapp1.Data.razorapp1Context _context;

        public IndexModel(razorapp1.Data.razorapp1Context context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.ToListAsync();
        }
    }
}
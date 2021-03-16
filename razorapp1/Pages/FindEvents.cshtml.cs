using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorapp1.Pages
{
    public class FindEvent : PageModel
    {
    
        private readonly ILogger<FindEvent> _logger;

        public FindEvent(ILogger<FindEvent> logger)
        {
            _logger = logger;
        }

        public List<Models.Event> Event { get; set; }





        public void OnGet()
        {
        }
    }
}

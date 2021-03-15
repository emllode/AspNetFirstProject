using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorapp1.Models;

namespace razorapp1.Data
{
    public class razorapp1Context : DbContext
    {
        public razorapp1Context (DbContextOptions<razorapp1Context> options)
            : base(options)
        {
        }

        public DbSet<razorapp1.Models.Event> Event { get; set; }
    }
}

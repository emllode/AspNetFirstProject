using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using razorapp1.Data;
using System;
using System.Linq;


namespace razorapp1.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new razorapp1Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<razorapp1Context>>()))
            {

                if (context.Event.Any())
                {
                    return;   // DB has been seeded
                }



                context.Event.AddRange(

                    new Event
                    {
                        Title = "WayOutWest",
                        Description = "Best Music eeveer ",
                        Place = "Gothenburg",
                        SpotsAvailable = 25,
                        Date = DateTime.Now,
                      
                    }


                    ); ; 


                context.SaveChanges();
            }
        }
    }
}

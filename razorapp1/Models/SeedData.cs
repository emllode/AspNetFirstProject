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
                        SpotsAvailable = 125,
                        Date = DateTime.Now,
                      
                    },
                    new Event
                    {
                        Title = "Ung08",
                        Description = "Stockholm summer fesstival, stars like RIHANNA, ChrisBOY and more ",
                        Place = "Stockholm",
                        SpotsAvailable = 100,
                        Date = DateTime.Now,

                    },
                    new Event
                    {
                        Title = "Monthy Python Marathon",
                        Description = "MOVIES???? ",
                        Place = "Gothenburg",
                        SpotsAvailable = 25,
                        Date = DateTime.Now,

                    },
                    new Event
                    {
                        Title = "Backstreet boyz",
                        Description = "music music music ",
                        Place = "boomBam",
                        SpotsAvailable = 125,
                        Date = DateTime.Now,

                    },
                    new Event
                    {
                        Title = "tabalo ",
                        Description = "tiiiitttooo ",
                        Place = "Gothenburg",
                        SpotsAvailable = 300,
                        Date = DateTime.Now,

                    }


                    ); ; 


                context.SaveChanges();
            }
        }
    }
}

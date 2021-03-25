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

                Attendee[] attendees = new Attendee[] {
                new Attendee{Email="Bjorn@Bjorn.se", PhoneNumber="0101010101" }
                };
                context.AddRange(attendees);
                context.SaveChanges();

                Organizer[] organizers = new Organizer[] {
                new Organizer{Name="WayPutWest", Email="XXXX@XXX.se", PhoneNumber="232323232323"},
                };
                context.AddRange(organizers);
                context.SaveChanges();


                Event[] events = new Event[] {
                    new Event{   Title = "WayOutWest",
                            Description = "Best Music eeveer ",
                            Place = "Gothenburg",
                            SpotsAvailable = 125,
                            Date = DateTime.Now,
                            Organizer=organizers[0],
                    },

                    new Event{ Title = "Ung08",
                            Description = "Stockholm summer fesstival, stars like RIHANNA, ChrisBOY and more ",
                            Place = "Stockholm",
                            SpotsAvailable = 100,
                            Date = DateTime.Now,
                            Organizer=organizers[0]
                    },

                    new Event{
                            Title = "Monthy Python Marathon",
                            Description = "MOVIES???? ",
                            Place = "Gothenburg",
                            SpotsAvailable = 25,
                            Date = DateTime.Now,
                            Organizer=organizers[0]
                    },

                    new Event{    Title = "Backstreet boyz",
                            Description = "music music music ",
                            Place = "boomBam",
                            SpotsAvailable = 125,
                            Date = DateTime.Now,
                            Organizer=organizers[0]
                    },
                };
                context.AddRange(events);
                context.SaveChanges();
            }
        }
    }
}

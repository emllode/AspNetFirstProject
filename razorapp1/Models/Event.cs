using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace razorapp1.Models
{
    public class Event
    {
        public int ID { get; set; }
        public List<Organizer> Organizer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Address { get; set; }
        public int SpotsAvailable { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
    }
}

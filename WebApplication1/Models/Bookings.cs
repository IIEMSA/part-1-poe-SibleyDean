using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System;

namespace eventEasefour.Models
{
    public class Bookings
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public int EventId { get; set; }

        [Required]
        public int VenueId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BookingDate { get; set; } = DateTime.Now;

        public Event? Event { get; set; }
        public Venue? Venue { get; set; }
    }
}

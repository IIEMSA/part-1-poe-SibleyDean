using System.ComponentModel.DataAnnotations;

namespace eventEasefour.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(100)]
        public string EventName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EventDate { get; set; }

        public string? Description { get; set; }

        [Required]
        public int VenueId { get; set; }

        public Venue? Venue { get; set; }

        public ICollection<Bookings> Bookings { get; set; } = new List<Bookings>();
    }
}

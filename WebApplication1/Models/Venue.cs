using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace eventEasefour.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        [Required]
        [StringLength(100)]
        public string VenueName { get; set; }

        [Required]
        [StringLength(200)]
        public string Location { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Capacity { get; set; }

        [Url]
        [StringLength(255)]
        public string? ImageUrl { get; set; }

        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}

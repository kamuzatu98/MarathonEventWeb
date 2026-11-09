using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarathonEventWeb.Models
{
    [Table("Route")]
    public class Route
    {
        [Key]
        [Column("Route_ID")]
        public string Id { get; set; } = string.Empty;

        [Column("Event_ID")]
        public string EventId { get; set; } = string.Empty;

        [Column("Route_Name")]
        public string RouteName { get; set; } = string.Empty;

        [Column("Distance_KM")]
        public decimal DistanceKm { get; set; }

        [Column("Elevation_Gain")]
        public string? ElevationGain { get; set; }

        [ForeignKey(nameof(EventId))]
        public Event? Event { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarathonEventWeb.Models
{
    [Table("Event")]
    public class Event
    {
        [Key]
        [Column("Event_ID")]
        public string Id { get; set; } = string.Empty;

        [Column("Organizer_ID")]
        public string OrganizerId { get; set; } = string.Empty;

        [Column("Name")]
        public string Name { get; set; } = string.Empty;

        [Column("Event_Name")]
        public string EventName { get; set; } = string.Empty;

        [Column("Event_Description")]
        public string? EventDescription { get; set; }

        [Column("Event_Location")]
        public string EventLocation { get; set; } = string.Empty;

        [Column("Distance")]
        public string Distance { get; set; } = string.Empty;

        [Column("Event_type")]
        public string EventType { get; set; } = string.Empty;

        [Column("BannerImageURL")]
        public string? BannerImageUrl { get; set; }

        [Column("Created_At")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("Updated_At")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(OrganizerId))]
        public Account? Organizer { get; set; }
    }
}
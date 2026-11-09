using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarathonEventWeb.Models
{
    [Table("Enrollment")]
    public class Enrollment
    {
        [Key]
        [Column("Enrollment_ID")]
        public string Id { get; set; } = string.Empty;

        [Column("Event_ID")]
        public string EventId { get; set; } = string.Empty;

        [Column("Participant_ID")]
        public string ParticipantId { get; set; } = string.Empty;

        [Column("Enrollment_Date")]
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;

        [ForeignKey(nameof(EventId))]
        public Event? Event { get; set; }

        [ForeignKey(nameof(ParticipantId))]
        public Account? Participant { get; set; }
    }
}
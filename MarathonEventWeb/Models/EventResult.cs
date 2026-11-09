using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarathonEventWeb.Models
{
    [Table("Results")]
    public class EventResult
    {
        [Key]
        [Column("Result_ID")]
        public string Id { get; set; } = string.Empty;

        [Column("Enrollment_ID")]
        public string EnrollmentId { get; set; } = string.Empty;

        [Column("Finish_Time")]
        public TimeSpan? FinishTime { get; set; }

        [Column("Finish_Position")]
        public int? FinishPosition { get; set; }

        [Column("Is_Published")]
        public bool IsPublished { get; set; }

        [Column("Recorded_At")]
        public DateTime RecordedAt { get; set; } = DateTime.Now;

        [Column("Published_At")]
        public DateTime? PublishedAt { get; set; }

        [ForeignKey(nameof(EnrollmentId))]
        public Enrollment? Enrollment { get; set; }
    }
}
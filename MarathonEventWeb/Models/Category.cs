using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarathonEventWeb.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [Column("Category_ID")]
        public string Id { get; set; } = string.Empty;

        [Column("Event_ID")]
        public string EventId { get; set; } = string.Empty;

        [Column("Category_Name")]
        public string CategoryName { get; set; } = string.Empty;

        [Column("Category_Type")]
        public string CategoryType { get; set; } = string.Empty;

        [Column("Distance")]
        public string Distance { get; set; } = string.Empty;

        [ForeignKey(nameof(EventId))]
        public Event? Event { get; set; }
    }
}
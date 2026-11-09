using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarathonEventWeb.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [Column("Account_ID")]
        public string Id { get; set; } = string.Empty;

        [Column("First_Name")]
        public string FirstName { get; set; } = string.Empty;

        [Column("Last_Name")]
        public string LastName { get; set; } = string.Empty;

        [Column("Email")]
        public string Email { get; set; } = string.Empty;

        [Column("Role")]
        public string Role { get; set; } = string.Empty;

        [Column("Created_At")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
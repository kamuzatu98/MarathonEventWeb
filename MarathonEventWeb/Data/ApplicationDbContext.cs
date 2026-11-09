using Microsoft.EntityFrameworkCore;
using MarathonEventWeb.Models;

namespace MarathonEventWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<MarathonEventWeb.Models.Route> Routes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<EventResult> Results { get; set; }
    }
}
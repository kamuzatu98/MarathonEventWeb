using Microsoft.EntityFrameworkCore;
using MarathonEventWeb.Models;

namespace MarathonEventWeb.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Accounts.Any())
                {
                    return;   // DB has been seeded
                }

                // 1. Seed Accounts
                var accounts = new Account[]
                {
                    new Account { Id = "ACC-001", FirstName = "Jeremiah", LastName = "Kamuzatu", Email = "jeremiah@tanya.com", Role = "RolOrg", CreatedAt = DateTime.Now },
                    new Account { Id = "ACC-002", FirstName = "Hailey", LastName = "Kamuzatu", Email = "hailey@tanya.com", Role = "RolePart", CreatedAt = DateTime.Now },
                    new Account { Id = "ACC-003", FirstName = "Belinda", LastName = "Smith", Email = "belinda@smith.com", Role = "RolePart", CreatedAt = DateTime.Now }
                };
                context.Accounts.AddRange(accounts);
                context.SaveChanges();

                // 2. Seed Events
                var events = new Event[]
                {
                    new Event
                    {
                        Id = "EVT-001",
                        OrganizerId = "ACC-001",
                        Name = "Cape Town Spring Marathon",
                        EventName = "CT Spring Marathon 2026",
                        EventDescription = "Annual scenic marathon running through Cape Town city and coastal lines.",
                        EventLocation = "Cape Town City Centre",
                        Distance = "42.2 KM",
                        EventType = "Marathon",
                        CreatedAt = DateTime.Now
                    },
                    new Event
                    {
                        Id = "EVT-002",
                        OrganizerId = "ACC-001",
                        Name = "Langa Community Fun Run",
                        EventName = "Langa 10K Challenge",
                        EventDescription = "Local community run promoting health and fitness.",
                        EventLocation = "Langa, Cape Town",
                        Distance = "10 KM",
                        EventType = "Road Race",
                        CreatedAt = DateTime.Now
                    }
                };
                context.Events.AddRange(events);
                context.SaveChanges();

                // 3. Seed Routes (Fully qualified to avoid namespace conflict)
                var routes = new MarathonEventWeb.Models.Route[]
                {
                    new MarathonEventWeb.Models.Route { Id = "RTE-001", EventId = "EVT-001", RouteName = "Atlantic Coast Loop", DistanceKm = 42.2M, ElevationGain = "250m" },
                    new MarathonEventWeb.Models.Route { Id = "RTE-002", EventId = "EVT-002", RouteName = "Township Heritage Circuit", DistanceKm = 10.0M, ElevationGain = "50m" }
                };
                context.Routes.AddRange(routes);

                // 4. Seed Categories
                var categories = new Category[]
                {
                    new Category { Id = "CAT-001", EventId = "EVT-001", CategoryName = "Open Senior", CategoryType = "Competitive", Distance = "42.2 KM" },
                    new Category { Id = "CAT-002", EventId = "EVT-002", CategoryName = "Junior Open", CategoryType = "Recreational", Distance = "10 KM" }
                };
                context.Categories.AddRange(categories);

                context.SaveChanges();
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace Mock1.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Luxury Villa",
                    Details = "This villa offers breathtaking views of the ocean and comes with a private pool.",
                    Rate = 500.00,
                    Occupancy = 8,
                    ImageUrl = "https://example.com/villa1.jpg",
                    Amenity = "Private pool, ocean view",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Name = "Cozy Retreat",
                    Details = "Escape to this cozy villa nestled in the mountains, perfect for a romantic getaway.",
                    Rate = 300.00,
                    Occupancy = 4,
                    ImageUrl = "https://example.com/villa2.jpg",
                    Amenity = "Mountain view, fireplace",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
                // Add more seed data as needed
            );
        }
    }
}


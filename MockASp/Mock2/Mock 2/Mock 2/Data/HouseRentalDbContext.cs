using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Mock_2.Model.Entity;
using System.Reflection;

namespace Mock_2.Data
{
    public class HouseRentalDbContext : DbContext
    {
        public HouseRentalDbContext(DbContextOptions<HouseRentalDbContext> options) : base(options)
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<Commune> Commune { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<HouseImage> HouseImages { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomHistory> RoomHistories { get; set; }
        public DbSet<RoomImage> RoomImages { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Village> Villages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    RoleID = 1,
                    RoleName = "John",
                    CreatedDate = DateTime.Now
                }
                );
            modelBuilder.Entity<UserRole>().HasData(
           new UserRole
           {
               RoleID = 2,
               RoleName = "Mark",
               CreatedDate = DateTime.Now
           }
           );
            modelBuilder.Entity<UserRole>().HasData(
           new UserRole
           {
               RoleID = 3,
               RoleName = "Lmao",
               CreatedDate = DateTime.Now
           }
           );

        }
    }
}

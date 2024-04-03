using Demo1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                StudentId = 1,  
                FirstName = "Jospeh",
                LastName = "Stalin",
                Email = "Stalin123@gmail.com",
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = ":C/Image/1"
                }
                );
            modelBuilder.Entity<Student>().HasData(
           new Student
           {
               StudentId = 2,
               FirstName = "Vladimir",
               LastName = "Lenin",
               Email = "Lenin23@gmail.com",
               Gender = Gender.Male,
               DepartmentId = 1,
               PhotoPath = ":C/Image/1"
           }
           );
            modelBuilder.Entity<Student>().HasData(
           new Student
           {
               StudentId = 3,
               FirstName = "Nikita",
               LastName = "Kruchev",
               Email = "Kruchev123@gmail.com",
               Gender = Gender.Male,
               DepartmentId = 1,
               PhotoPath = ":C/Image/1"
           }
           );


        }

    }
}

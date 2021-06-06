using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;

namespace CodeFirst.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Fluent API
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomModel>()
                .Property(r => r.RoomType)
                .IsRequired();

            // seeding
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                FirstName = "Abdullah",
                LastName = "AL Haif",
                Email = "aalhaif@hotmail.com"
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 2,
                FirstName = "AbdulAziz",
                LastName = "Almohammadi",
                Email = "Ezz@gmail.com"
            });
           

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 3,
                FirstName = "Sarah",
                LastName = "AlNasser",
                Email = "s.nasser@hotmail.com"

            }) ;
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; } 
        public DbSet<RoomModel>Rooms { get; set; } 

        // We can add feild using AddField

    }
}

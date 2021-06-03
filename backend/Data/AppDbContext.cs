using backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Students seed data
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1943222, Name = "Younes Alturkey", Major = "Lawn Mower", Grade = 1, Email = "younes.alturkey@tuwaiq.edu.sa", Phone = "0538654514" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1941214, Name = "Fai Alotaibi", Major = "Software Engineering", Grade = 100, Email = "fai.alotaibi@tuwaiq.edu.sa", Phone = "0554523654" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1948456, Name = "Abdulrahman Bin Manea", Major = "Cyber Security", Grade = 99, Email = "abdulrahman.binmanea@tuwaiq.edu.sa", Phone = "0536525451" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1947453, Name = "Reema Alyousef", Major = "Meme Artist", Grade = 27, Email = "reema.alyousef@tuwaiq.edu.sa", Phone = "0543259658" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1949651, Name = "Riyad Alghamdi", Major = "Graphic Designer", Grade = 33, Email = "riyad.alghamdi@tuwaiq.edu.sa", Phone = "0543251221" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1949677, Name = "Batool Alghamdi", Major = "Algorithms Science", Grade = 57, Email = "batool.alghamdighamdi@tuwaiq.edu.sa", Phone = "0543251136" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1944532, Name = "Sami Aldahlawi", Major = "Education Excellence", Grade = 89, Email = "sami.aldahlawi@tuwaiq.edu.sa", Phone = "0556523254" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1949657, Name = "Eman Yahya", Major = "School Managment", Grade = 44, Email = "eman.yahya@tuwaiq.edu.sa", Phone = "0543254865" });

            // Instructor seed data
            modelBuilder.Entity<Instructor>().HasData(new Instructor { Id = 1013254, Name = "Khalid Altuwaim", Speciality = "Frontend - React", Rating = 4, Email = "khalid.altuwaim@tuwaiq.edu.sa", Phone = "0543254512", BootcampId = 6 });
            modelBuilder.Entity<Instructor>().HasData(new Instructor { Id = 1014512, Name = "Abdullah Alhaif", Speciality = "Backend - Ruby", Rating = 5, Email = "abdullah.alhaif@tuwaiq.edu.sa", Phone = "0545651234", BootcampId = 6 });
            modelBuilder.Entity<Instructor>().HasData(new Instructor { Id = 1017456, Name = "Meshal Alzahrani", Speciality = "Frontend - React", Rating = 3, Email = "meshal.alzahrani@tuwaiq.edu.sa", Phone = "0553264512", BootcampId = 6 });
            modelBuilder.Entity<Instructor>().HasData(new Instructor { Id = 1014845, Name = "Wael Aldaki", Speciality = "Database - SQLServer", Rating = 5, Email = "wael.aldaki@tuwaiq.edu.sa", Phone = "0553236584", BootcampId = 6 });
            modelBuilder.Entity<Instructor>().HasData(new Instructor { Id = 1014798, Name = "Nouf Alhassan", Speciality = "Unit Testing - MSTest", Rating = 5, Email = "noura.alhassan@tuwaiq.edu.sa", Phone = "0556562312", BootcampId = 6 });
            modelBuilder.Entity<Instructor>().HasData(new Instructor { Id = 1014412, Name = "Norah Mohsen", Speciality = "Design Patterns - Refactoring Guru", Rating = 4, Email = "norah.mohsen@tuwaiq.edu.sa", Phone = "0553254512", BootcampId = 6 });
            modelBuilder.Entity<Instructor>().HasData(new Instructor { Id = 1014795, Name = "Abdulaziz Alasmari", Speciality = "OS - Parallelism", Rating = 4, Email = "abdulaziz.alasmari@tuwaiq.edu.sa", Phone = "0543235124", BootcampId = 6 });
            modelBuilder.Entity<Instructor>().HasData(new Instructor { Id = 1011234, Name = "Anas Alhmoud", Speciality = "Quick Maths - Real Quick", Rating = 3, Email = "anas.alhmoud@tuwaiq.edu.sa", Phone = "0543235124", BootcampId = 6 });

            // Principles seed data
            modelBuilder.Entity<Principle>().HasData(new Principle { Id = 6954512, Name = "Abdullah Eid", Rating = 99, Email = "abdullah.eid@tuwaiq.edu.sa", Phone = "0543251247" });

            // Managers seed data
            modelBuilder.Entity<Manager>().HasData(new Manager { Id = 8651234, Name = "Mohammed Essa", Department = "Military", Email = "mohammed.essa@tuwaiq.edu.sa", Phone = "0543251453" });
            modelBuilder.Entity<Manager>().HasData(new Manager { Id = 8658456, Name = "Abdullah Alsanea", Department = "Bootcamp Managment", Email = "abdullah.alsanea@tuwaiq.edu.sa", Phone = "0543251247" });
            modelBuilder.Entity<Manager>().HasData(new Manager { Id = 8657466, Name = "Abrar Alqubishi", Department = "Bootcamp Managment", Email = "abrar.alqubishi@tuwaiq.edu.sa", Phone = "0543251457" });

            // Instructor_Students seed data
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 745, StudentId = 1949657, InstructorId = 1017456, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 746, StudentId = 1949657, InstructorId = 1011234, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 748, StudentId = 1948456, InstructorId = 1017456, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 750, StudentId = 1944532, InstructorId = 1017456, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 753, StudentId = 1941214, InstructorId = 1011234, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 756, StudentId = 1949657, InstructorId = 1017456, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 777, StudentId = 1949677, InstructorId = 1011234, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 787, StudentId = 1949651, InstructorId = 1011234, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 799, StudentId = 1941214, InstructorId = 1014512, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 854, StudentId = 1948456, InstructorId = 1014512, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 823, StudentId = 1949651, InstructorId = 1014512, StartDate = new DateTime() });
            modelBuilder.Entity<InstructorStudent>().HasData(new InstructorStudent { Id = 899, StudentId = 1943222, InstructorId = 1014512, StartDate = new DateTime() });

            // Teams seed data
           modelBuilder.Entity<Team>().HasData(new Team { Id = 14, Name = "Red Sea", InstructorId = 1017456, FormDate = new DateTime() });
            modelBuilder.Entity<Team>().HasData(new Team { Id = 15, Name = "Qiddiya", InstructorId = 1011234, FormDate = new DateTime() });
            modelBuilder.Entity<Team>().HasData(new Team { Id = 16, Name = "Tuwaiq", InstructorId = 1014512, FormDate = new DateTime() });
            modelBuilder.Entity<Team>().HasData(new Team { Id = 17, Name = "Saudi To The Stars", InstructorId = 1014845, FormDate = new DateTime() });
            modelBuilder.Entity<Team>().HasData(new Team { Id = 18, Name = "MBS", InstructorId = 1017456, FormDate = new DateTime() });
            modelBuilder.Entity<Team>().HasData(new Team { Id = 19, Name = "Abdulaziz", InstructorId = 1013254, FormDate = new DateTime() });
            modelBuilder.Entity<Team>().HasData(new Team { Id = 20, Name = "Diriyah", InstructorId = 1014512, FormDate = new DateTime() });

            // Bootcamps seed data
            modelBuilder.Entity<Bootcamp>().HasData(new Bootcamp { Id = 6, Name = "Tuwaiq .Net",
                Students = new List<Student> {}, Instructors = new List<Instructor> {}, Managers = new List<Manager> {}, PrincipleId = 6954512, Capacity = 50, Level = "Beginner", StartDate = new DateTime(), EndDate = new DateTime() });

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Principle> Principles { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<InstructorStudent> Instructor_Students { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Bootcamp> Bootcamps { get; set; }
    }
}

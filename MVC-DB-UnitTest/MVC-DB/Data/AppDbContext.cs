using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MVC_DB.Models;

namespace MVC_DB.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //Create table in database and map it into my project
        public DbSet<StudnetModel> Studnets { get; set; }
        public DbSet<TeacherModel> Teachers { get; set; }
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentTeacherModel> Student_Teacher { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<RoomModel>().Property(r => r.avalibalty).HasDefaultValue("Null");

            //seeding
            modelBuilder.Entity<StudnetModel>().HasData(new StudnetModel { ID = 1, firstName = "Rawabe", lastName = "Ebrahim", email = "rawabe44u@gmail.com" });
            modelBuilder.Entity<StudnetModel>().HasData(new StudnetModel { ID = 2, firstName = "Reema", lastName = "Alyosif", email = "reema@gmail.com" });
            modelBuilder.Entity<StudnetModel>().HasData(new StudnetModel { ID = 3, firstName = "Amal", lastName = "Alagel", email = "amal@gmail.com" });

        }

    }

}

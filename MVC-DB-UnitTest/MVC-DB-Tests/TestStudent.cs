using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using MVC_DB.Controllers;
using System;
using Microsoft.AspNetCore.Mvc;
using MVC_DB.Data;
using MVC_DB.Models;
namespace MVC_DB_Tests
{
    [TestFixture]
    public class Tests
    {
        
        [Test]
        public void TestInsertStudentsData()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "courses").Options;
            var context = new AppDbContext(options);
            var query = new StudnetsController(context);

            Seeding(context);

            //Act
            var result = query.Excute();

            //Assert //Expect 3 records
            Assert.AreEqual(3, result.Count);//1. Test if data saved to database same as actual
        }

        [Test]
        public void TestOrderByFirstName()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "courses").Options;
            var context = new AppDbContext(options);
            var query = new StudnetsController(context);

            Seeding(context);

            //Act
            var result = query.Excute();

            //Assert 
            Assert.AreEqual("Ameen", result.FirstOrDefault().firstName); //2. Test if data ordered by first Name alphapatically
        }


        //Function for test data
        public void Seeding(AppDbContext context)
        {
            
            var students = new[]
            {
                new StudnetModel {firstName = "Ahmed"},
                new StudnetModel {firstName = "Rashed"},
                new StudnetModel {firstName = "Ameen"}
            };
            context.Studnets.AddRange(students);
            context.SaveChanges(); // save changes to the database
        }
    }
}
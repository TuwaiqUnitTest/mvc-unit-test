using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesLibrary.Controllers;
using MoviesLibrary.Data;
using MoviesLibrary.Models;
using NUnit.Framework;

namespace MoviesLibraryNUnitTests.Controllers
{
    [TestFixture]
    public class MoviesControllerTests : Controller
    {
        
        static DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(databaseName: "MockDB").Options;
        // Temporary database for testing purposes
        static AppDbContext context = new AppDbContext (options);
        private MoviesController controller;
        
        [SetUp]
        public void SetUp()
        {
            Movie movie = new Movie() { Id = 1, Date = "2021-12-22", Title = "IBRA", Rating = 10, Poster = "asdf"};
            context.Add(movie);
            context.SaveChanges();
            controller = new MoviesController(context);
        }
        
        [Test]
        public void GetIsNotNullTest()
        {
            
            
            Assert.IsNotNull(controller.Get());
        }
        
        // GET
        [Test]
        public void GetTest()
        {
            
            
            Assert.AreEqual("IBRA", controller.Get().First().Title );
        }
        
        [Test]
        public void GetAreNotEqualTest()
        {
            
            
            Assert.AreNotEqual(3, controller.Get().First().Rating );
        }
        
        [Test]
        public void GetWithIdIsNotNullTest()
        {
            
            
            Assert.IsNotNull(controller.Get(1));
        }
        
        [Test]
        public void GetWithIdTest()
        {

            
            Assert.AreEqual("IBRA", controller.Get(1).First().Title );
        }
    }
}
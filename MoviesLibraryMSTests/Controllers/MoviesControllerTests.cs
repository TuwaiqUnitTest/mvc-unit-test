using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesLibrary.Controllers;
using MoviesLibrary.Data;
using MoviesLibrary.Models;

namespace MoviesLibraryTests.Controllers
{
    [TestClass]
    public class MoviesControllerMSTests : Controller
    {
        static DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(databaseName: "MockDB").Options;
        
        static AppDbContext context = new AppDbContext (options);
        
        //Arrange
        MoviesController controller = new MoviesController(context);
        
        // GET
        [TestMethod]
        public void GetTest()
        {

            Movie movie = new Movie() { Id = 1, Date = "2021-12-22", Title = "IBRA", Rating = 10, Poster = "asdf"};
            context.Add(movie);
            context.SaveChanges();
            
            Assert.AreEqual("IBRA", controller.Get().First().Title );
            
        }
        
        [TestMethod]
        public void GetIsNotNullTest()
        {
            Movie movie = new Movie() { Id = 1, Date = "2021-12-22", Title = "IBRA", Rating = 10, Poster = "asdf"};
            context.Add(movie);
            context.SaveChanges();
            
            Assert.IsNotNull(controller.Get());
        }
    }
}
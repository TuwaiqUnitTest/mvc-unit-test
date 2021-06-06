using System.Linq;
using Microsoft.EntityFrameworkCore;
using MoviesLibrary.Controllers;
using MoviesLibrary.Data;
using MoviesLibrary.Models;
using NUnit.Framework;

namespace MoviesLibraryNUnitTests.Controllers
{
    [TestFixture]
    public class FavoriteMoviesControllerTests
    {
        static DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(databaseName: "MockDB").Options;
        // Temporary database for testing purposes
        static AppDbContext context = new AppDbContext (options);
        private FavoriteMoviesController controller;
        
        [SetUp]
        public void SetUp()
        {
            Movie movie = new Movie() { Id = 1, Date = "2021-12-22", Title = "IBRA", Rating = 10, Poster = "asdf"};
            FavoriteMovie favMovie = new FavoriteMovie() { Id = 1, MovieId = 1, Movie = movie};
            context.Add(favMovie);
            context.SaveChanges();
            controller = new FavoriteMoviesController(context);
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
            Assert.AreNotEqual(5, controller.Get().First().Rating );
        }
    }
}
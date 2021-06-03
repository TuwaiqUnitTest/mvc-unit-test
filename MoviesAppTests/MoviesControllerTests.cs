using Microsoft.EntityFrameworkCore;
using MoviesApp.Controllers;
using MoviesApp.Data;
using MoviesApp.Models;
using NUnit.Framework;

namespace MoviesAppTests
{
    public class MoviesControllerTests
    {
        private MoviesContext db;
        
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<MoviesContext>()
                .UseInMemoryDatabase(databaseName: "MovieListDatabase")
                .Options;
            
            // Insert seed data into the database using one instance of the context
            db = new MoviesContext(options);
            db.Movies.Add(new Movie {ID = 1, Name = "Movie 1", CoverURL = "example cover", Rating = 7});
            db.Movies.Add(new Movie {ID = 2, Name = "Movie 2", CoverURL = "example cover", Rating = 7});
            db.Movies.Add(new Movie {ID = 3, Name = "Movie 3", CoverURL = "example cover", Rating = 7});
            db.SaveChanges();
        }
        
        /*[Test]
        public void IndexTests()
        {
            // Arrange
            MoviesController controller = new MoviesController(this.db);
            // Act
            // Assert
            Assert.Pass();
        }*/
    }
}
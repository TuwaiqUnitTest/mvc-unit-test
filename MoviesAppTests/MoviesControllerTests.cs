using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        
        [OneTimeSetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<MoviesContext>()
                .UseInMemoryDatabase(databaseName: "MovieListDatabase")
                .Options;
            
            // Insert seed data into the database using one instance of the context
            db = new MoviesContext(options);
            db.Movies.Add(new Movie {ID = 1, Name = "Movie 1", CoverURL = "example cover", Rating = 7});
            db.Movies.Add(new Movie {ID = 2, Name = "Movie 2", CoverURL = "example cover", Rating = 10});
            db.Movies.Add(new Movie {ID = 3, Name = "Movie 3", CoverURL = "example cover", Rating = 7});
            db.SaveChanges();
        }
        
        [Test, Order(1)]
        public async Task IndexSuccessTest()
        {
            // Arrange
            int expectedCount = 3;
            int expectedStatusCode = 200;
            MoviesController controller = new MoviesController(this.db);
            
            // Act
            var actionResult = await controller.Index(false);
            
            // Assert
            Assert.IsTrue(actionResult.Result is OkObjectResult, "Invalid action result type");
            var result = actionResult.Result as OkObjectResult;
            
            Assert.AreEqual(expectedStatusCode, result.StatusCode, "Invalid status code");

            Assert.IsTrue(result.Value is List<Movie>, "Invalid value type");
            var movies = result.Value as List<Movie>;
            
            Assert.AreEqual(expectedCount, movies.Count, "Invalid list count");
            Assert.Pass();
        }

        [Test, Order(2)]
        public async Task ShowSuccessTest()
        {
            // Arrange
            int movieId = 1;
            int expectedStatusCode = 200;
            MoviesController controller = new MoviesController(this.db);
            
            // Act
            var actionResult = await controller.Show(movieId);
            
            // Assert
            Assert.IsTrue(actionResult.Result is OkObjectResult, "Invalid action result type");
            var result = actionResult.Result as OkObjectResult;
            
            Assert.AreEqual(expectedStatusCode, result.StatusCode, "Invalid status code");
            
            Assert.IsTrue(result.Value is Movie, "Invalid value type");
            var movie = result.Value as Movie;
            
            Assert.NotNull(movie, "Invalid value");
            Assert.AreEqual(movieId, movie.ID, "Invalid movie id");
            Assert.Pass();
        }
        
        [Test, Order(3)]
        public async Task ShowFailTest()
        {
            // Arrange
            int movieId = 300;
            int expectedStatusCode = 404;
            MoviesController controller = new MoviesController(this.db);
            
            // Act
            var actionResult = await controller.Show(movieId);
            
            // Assert
            Assert.IsTrue(actionResult.Result is NotFoundResult, "Invalid action result type");
            var result = actionResult.Result as NotFoundResult;
            
            Assert.AreEqual(expectedStatusCode, result.StatusCode, "Invalid status code");
            Assert.Pass();
        }
        
        [Test, Order(4)]
        public async Task DeleteSuccessTest()
        {
            // Arrange
            int movieId = 1;
            int expectedStatusCode = 200;
            MoviesController controller = new MoviesController(this.db);
            
            // Act
            var actionResult = await controller.Delete(movieId);
            
            // Assert
            Assert.IsTrue(actionResult.Result is OkObjectResult, "Invalid action result type");
            var result = actionResult.Result as OkObjectResult;
            
            Assert.AreEqual(expectedStatusCode, result.StatusCode, "Invalid status code");
            
            Assert.IsTrue(result.Value is Movie, "Invalid value type");
            var movie = result.Value as Movie;
            
            Assert.NotNull(movie, "Invalid value");
            Assert.AreEqual(movieId, movie.ID, "Invalid movie id");
            Assert.Pass();
        }
        
        [Test, Order(5)]
        public async Task DeleteFailTest()
        {
            // Arrange
            int movieId = 1;
            int expectedStatusCode = 404;
            MoviesController controller = new MoviesController(this.db);
            
            // Act
            var actionResult = await controller.Delete(movieId);
            
            // Assert
            Assert.IsTrue(actionResult.Result is NotFoundResult, "Invalid action result type");
            var result = actionResult.Result as NotFoundResult;
            
            Assert.AreEqual(expectedStatusCode, result.StatusCode, "Invalid status code");
            Assert.Pass();
        }
    }
}
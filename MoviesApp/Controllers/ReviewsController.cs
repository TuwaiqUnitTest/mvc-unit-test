using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Models;

namespace MoviesApp.Controllers
{
    [ApiController]
    [Route("api/v1/movies/{movieId:int}/[controller]")]
    public class ReviewsController : ControllerBase
    {
        private MoviesContext db { get; }
        
        public ReviewsController(MoviesContext db)
        {
            this.db = db;
        }
        
        // GET: api/v1/movies/1/reviews
        [HttpGet]
        public async Task<ActionResult<List<Review>>> Index([FromRoute] int movieId)
        {
            Movie movie = await this.db.Movies.Include(movie => movie.Reviews).FirstOrDefaultAsync(movie => movie.ID == movieId);

            if (movie == null)
                return NotFound();
            
            return Ok(movie.Reviews.ToList<Review>());
        }

        // GET api/v1/movies/1/reviews/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Review>> Show([FromRoute] int movieId, [FromRoute] int id)
        {
            Movie movie = await this.db.Movies.Include(movie => movie.Reviews).FirstOrDefaultAsync(movie => movie.ID == movieId);

            if (movie == null)
                return NotFound();

            Review review = movie.Reviews.FirstOrDefault(review => review.ID == id);

            if (review == null)
                return NotFound();
            
            return Ok(review);
        }

        // POST api/v1/movies/1/reviews
        [HttpPost]
        public async Task<ActionResult<Review>> Create([FromRoute] int movieId, [FromBody] Review input)
        {
            // TODO validate data
            Movie movie = await this.db.Movies.Include(movie => movie.Reviews).FirstOrDefaultAsync(movie => movie.ID == movieId);

            if (movie == null)
                return NotFound();

            var review = new Review();
            review.Author = input.Author;
            review.Content = input.Content;
            
            movie.Reviews.Add(review);
            this.db.Movies.Update(movie);
            await this.db.SaveChangesAsync();
            return Ok(review);
        }

        // PUT api/v1/movies/1/reviews/5
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Review>> Update([FromRoute] int movieId, [FromRoute] int id, [FromBody] Review input)
        {
            // TODO validate data
            Movie movie = await this.db.Movies.Include(movie => movie.Reviews).FirstOrDefaultAsync(movie => movie.ID == movieId);

            if (movie == null)
                return NotFound();

            Review review = movie.Reviews.FirstOrDefault(review => review.ID == id);

            if (review == null)
                return NotFound();

            review.Author = input.Author;
            review.Content = input.Content;
            this.db.Reviews.Update(review);
            await this.db.SaveChangesAsync();
            return Ok(review);
        }

        // DELETE api/v1/movies/1/reviews/5
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Review>> Delete([FromRoute] int movieId, [FromRoute] int id)
        {
            Movie movie = await this.db.Movies.Include(movie => movie.Reviews).FirstOrDefaultAsync(movie => movie.ID == movieId);
            
            if (movie == null)
                return NotFound();

            Review review = movie.Reviews.FirstOrDefault(review => review.ID == id);

            if (review == null)
                return NotFound();
            
            movie.Reviews.Remove(review);
            await this.db.SaveChangesAsync();
            return Ok(review);
        }
    }
}
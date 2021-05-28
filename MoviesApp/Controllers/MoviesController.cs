using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Models;

namespace MoviesApp.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MoviesController : ControllerBase
    {
        private MoviesContext db { get; }

        public MoviesController(MoviesContext db)
        {
            this.db = db;
        }
        
        // GET: api/v1/movies
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return Ok(await this.db.Movies.Include(movie => movie.Reviews).ToListAsync());
        }

        // GET api/v1/movies/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Show([FromRoute] int id)
        {
            return Ok(await this.db.Movies.Include(movie => movie.Reviews).FirstOrDefaultAsync(movie => movie.ID == id));
        }

        // POST api/v1/movies
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Movie movie)
        {
            // TODO validate data
            await this.db.Movies.AddAsync(movie);
            await this.db.SaveChangesAsync();
            return Ok(movie);
        }

        // PUT api/v1/movies/5
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] Movie input)
        {
            // TODO validate data
            Movie movie = await this.db.Movies.FirstOrDefaultAsync(movie => movie.ID == id);

            if (movie == null)
                return NotFound();

            movie.Name = input.Name;
            movie.CoverURL = input.CoverURL;
            this.db.Movies.Update(movie);
            await this.db.SaveChangesAsync();
            return Ok(movie);
        }

        // DELETE api/v1/movies/5
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            Movie movie = await this.db.Movies.FirstOrDefaultAsync(movie => movie.ID == id);
            
            if (movie == null)
                return NotFound();
            
            this.db.Movies.Remove(movie);
            await this.db.SaveChangesAsync();
            return Ok(movie);
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace MoviesApp.Controllers
{
    [Route("api/v1/movies/{movieId:int}/[controller]")]
    public class ReviewsController : Controller
    {
        // GET: api/v1/movies/1/reviews
        [HttpGet]
        public ActionResult Index([FromRoute] int movieId)
        {
            return Ok();
        }

        // GET api/v1/movies/1/reviews/5
        [HttpGet("{id:int}")]
        public ActionResult Show([FromRoute] int movieId, [FromRoute] int id)
        {
            return Ok();
        }

        // POST api/v1/movies/1/reviews
        [HttpPost]
        public ActionResult Create([FromRoute] int movieId)
        {
            return Ok();
        }

        // PUT api/v1/movies/1/reviews/5
        [HttpPut("{id:int}")]
        public ActionResult Update([FromRoute] int movieId, [FromRoute] int id)
        {
            return Ok();
        }

        // DELETE api/v1/movies/1/reviews/5
        [HttpDelete("{id:int}")]
        public ActionResult Delete([FromRoute] int movieId, [FromRoute] int id)
        {
            return Ok();
        }
    }
}
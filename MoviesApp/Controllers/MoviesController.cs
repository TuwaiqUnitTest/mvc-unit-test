using System.Collections.Generic;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace MoviesApp.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MoviesController : ControllerBase
    {
        // GET: api/v1/movies
        [HttpGet]
        public ActionResult Index()
        {
            return Ok();
        }

        // GET api/v1/movies/5
        [HttpGet("{id:int}")]
        public ActionResult Show([FromRoute] int id)
        {
            return Ok();
        }

        // POST api/v1/movies
        [HttpPost]
        public ActionResult Create()
        {
            return Ok();
        }

        // PUT api/v1/movies/5
        [HttpPut("{id:int}")]
        public ActionResult Update([FromRoute] int id)
        {
            return Ok();
        }

        // DELETE api/v1/movies/5
        [HttpDelete("{id:int}")]
        public ActionResult Delete([FromRoute] int id)
        {
            return Ok();
        }
    }
}
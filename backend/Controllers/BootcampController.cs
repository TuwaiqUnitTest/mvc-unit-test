using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootcampController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BootcampController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Bootcamp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bootcamp>>> GetBootcamps()
        {
            return await _context.Bootcamps.ToListAsync();
        }

        // GET: api/Bootcamp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bootcamp>> GetBootcamp(int id)
        {
            var bootcamp = await _context.Bootcamps.FindAsync(id);

            if (bootcamp == null)
            {
                return NotFound();
            }

            return bootcamp;
        }

        // PUT: api/Bootcamp/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBootcamp(int id, Bootcamp bootcamp)
        {
            if (id != bootcamp.Id)
            {
                return BadRequest();
            }

            _context.Entry(bootcamp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BootcampExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Bootcamp
        [HttpPost]
        public async Task<ActionResult<Bootcamp>> PostBootcamp(Bootcamp bootcamp)
        {
            _context.Bootcamps.Add(bootcamp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBootcamp", new { id = bootcamp.Id }, bootcamp);
        }

        // DELETE: api/Bootcamp/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBootcamp(int id)
        {
            var bootcamp = await _context.Bootcamps.FindAsync(id);
            if (bootcamp == null)
            {
                return NotFound();
            }

            _context.Bootcamps.Remove(bootcamp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BootcampExists(int id)
        {
            return _context.Bootcamps.Any(e => e.Id == id);
        }
    }
}

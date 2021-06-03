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
    public class PrincipleController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PrincipleController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Principle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Principle>>> GetPrinciples()
        {
            return await _context.Principles.ToListAsync();
        }

        // GET: api/Principle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Principle>> GetPrinciple(int id)
        {
            var principle = await _context.Principles.FindAsync(id);

            if (principle == null)
            {
                return NotFound();
            }

            return principle;
        }

        // PUT: api/Principle/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrinciple(int id, Principle principle)
        {
            if (id != principle.Id)
            {
                return BadRequest();
            }

            _context.Entry(principle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrincipleExists(id))
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

        // POST: api/Principle
        [HttpPost]
        public async Task<ActionResult<Principle>> PostPrinciple(Principle principle)
        {
            _context.Principles.Add(principle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrinciple", new { id = principle.Id }, principle);
        }

        // DELETE: api/Principle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrinciple(int id)
        {
            var principle = await _context.Principles.FindAsync(id);
            if (principle == null)
            {
                return NotFound();
            }

            _context.Principles.Remove(principle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrincipleExists(int id)
        {
            return _context.Principles.Any(e => e.Id == id);
        }
    }
}

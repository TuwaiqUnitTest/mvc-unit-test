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
    public class InstructorStudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InstructorStudentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/InstructorStudent
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InstructorStudent>>> GetInstructor_Students()
        {
            return await _context.Instructor_Students.ToListAsync();
        }

        // GET: api/InstructorStudent/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InstructorStudent>> GetInstructorStudent(int id)
        {
            var instructorStudent = await _context.Instructor_Students.FindAsync(id);

            if (instructorStudent == null)
            {
                return NotFound();
            }

            return instructorStudent;
        }

        // PUT: api/InstructorStudent/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstructorStudent(int id, InstructorStudent instructorStudent)
        {
            if (id != instructorStudent.Id)
            {
                return BadRequest();
            }

            _context.Entry(instructorStudent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstructorStudentExists(id))
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

        // POST: api/InstructorStudent
        [HttpPost]
        public async Task<ActionResult<InstructorStudent>> PostInstructorStudent(InstructorStudent instructorStudent)
        {
            _context.Instructor_Students.Add(instructorStudent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstructorStudent", new { id = instructorStudent.Id }, instructorStudent);
        }

        // DELETE: api/InstructorStudent/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstructorStudent(int id)
        {
            var instructorStudent = await _context.Instructor_Students.FindAsync(id);
            if (instructorStudent == null)
            {
                return NotFound();
            }

            _context.Instructor_Students.Remove(instructorStudent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InstructorStudentExists(int id)
        {
            return _context.Instructor_Students.Any(e => e.Id == id);
        }
    }
}

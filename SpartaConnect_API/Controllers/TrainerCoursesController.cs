using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpartaConnect_API.Models;

namespace SpartaConnect_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerCoursesController : ControllerBase
    {
        private readonly SpartaDBContext _context;

        public TrainerCoursesController(SpartaDBContext context)
        {
            _context = context;
        }

        // GET: api/TrainerCourses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainerCourses>>> GetTrainerCourses()
        {
            return await _context.TrainerCourses.ToListAsync();
        }

        // GET: api/TrainerCourses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainerCourses>> GetTrainerCourses(int id)
        {
            var trainerCourses = await _context.TrainerCourses.FindAsync(id);

            if (trainerCourses == null)
            {
                return NotFound();
            }

            return trainerCourses;
        }

        // PUT: api/TrainerCourses/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainerCourses(int id, TrainerCourses trainerCourses)
        {
            if (id != trainerCourses.CourseId)
            {
                return BadRequest();
            }

            _context.Entry(trainerCourses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainerCoursesExists(id))
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

        // POST: api/TrainerCourses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TrainerCourses>> PostTrainerCourses(TrainerCourses trainerCourses)
        {
            _context.TrainerCourses.Add(trainerCourses);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrainerCoursesExists(trainerCourses.CourseId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrainerCourses", new { id = trainerCourses.CourseId }, trainerCourses);
        }

        // DELETE: api/TrainerCourses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainerCourses>> DeleteTrainerCourses(int id)
        {
            var trainerCourses = await _context.TrainerCourses.FindAsync(id);
            if (trainerCourses == null)
            {
                return NotFound();
            }

            _context.TrainerCourses.Remove(trainerCourses);
            await _context.SaveChangesAsync();

            return trainerCourses;
        }

        private bool TrainerCoursesExists(int id)
        {
            return _context.TrainerCourses.Any(e => e.CourseId == id);
        }
    }
}

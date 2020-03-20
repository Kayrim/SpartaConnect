using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SpartaConnect_API.Models;

namespace SpartaConnect_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultantsController : ControllerBase
    {
        private readonly SpartaDBContext _context;

        public ConsultantsController(SpartaDBContext context)
        {
            _context = context;
        }

        // GET: api/Consultants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Consultant>>> GetConsultant()
        {
            return await _context.Consultant.ToListAsync();
        }

        // GET: api/Consultants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Consultant>> GetConsultant(int id)
        {
            var consultant = await _context.Consultant.FindAsync(id);

            if (consultant == null)
            {
                return NotFound();
            }

            return consultant;
        }

        // PUT: api/Consultants/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultant(int id, Consultant consultant)
        {
            if (id != consultant.ConsultantId)
            {
                return BadRequest();
            }

            _context.Entry(consultant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultantExists(id))
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

        // POST: api/Consultants
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Consultant>> PostConsultant([FromBody] List<Consultant> consultants)
        {
            foreach (var c in consultants)
            {
                _context.Consultant.Add(c);
            }
            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/Consultants/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Consultant>> DeleteConsultant(int id)
        {
            var consultant = await _context.Consultant.FindAsync(id);
            if (consultant == null)
            {
                return NotFound();
            }

            _context.Consultant.Remove(consultant);
            await _context.SaveChangesAsync();

            return consultant;
        }

        private bool ConsultantExists(int id)
        {
            return _context.Consultant.Any(e => e.ConsultantId == id);
        }
    }
}

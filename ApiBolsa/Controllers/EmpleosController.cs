using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiBolsa.Model;
using Microsoft.AspNetCore.Authorization;

namespace ApiBolsa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class EmpleosController : ControllerBase
    {
        private readonly BolsaContext _context;

        public EmpleosController(BolsaContext context)
        {
            _context = context;
        }

        // GET: api/Empleos
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleo>>> GetEmpleos()
        {
            return await _context.Empleos.ToListAsync();
        }

        // GET: api/Empleos/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleo>> GetEmpleo(int id)
        {
            var empleo = await _context.Empleos.FindAsync(id);

            if (empleo == null)
            {
                return NotFound();
            }

            return empleo;
        }

        // PUT: api/Empleos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Administrador")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleo(int id, Empleo empleo)
        {
            if (id != empleo.Id)
            {
                return BadRequest();
            }

            _context.Entry(empleo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // POST: api/Empleos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Empleo>> PostEmpleo(Empleo empleo)
        {
            _context.Empleos.Add(empleo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleo", new { id = empleo.Id }, empleo);
        }

        // DELETE: api/Empleos/5
        [Authorize(Roles= "Administrador")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleo(int id)
        {
            var empleo = await _context.Empleos.FindAsync(id);
            if (empleo == null)
            {
                return NotFound();
            }

            _context.Empleos.Remove(empleo);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool EmpleoExists(int id)
        {
            return _context.Empleos.Any(e => e.Id == id);
        }
    }
}

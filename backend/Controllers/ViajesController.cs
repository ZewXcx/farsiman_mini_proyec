using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Viajes.Data;
using Viajes.Models;

namespace Viajes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViajesController : ControllerBase
    {
        private readonly ViajeContext _context;

        public ViajesController(ViajeContext context)
        {
            _context = context;
        }

        // GET: api/Viajes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Viaje>>> GetViaje()
        {
            return await _context.Viaje.ToListAsync();
        }

        // GET: api/Viajes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Viaje>> GetViaje(int id)
        {
            var viaje = await _context.Viaje.FindAsync(id);

            if (viaje == null)
            {
                return NotFound();
            }

            return viaje;
        }

        // PUT: api/Viajes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutViaje(int id, Viaje viaje)
        {
            if (id != viaje.idViaje)
            {
                return BadRequest();
            }

            _context.Entry(viaje).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViajeExists(id))
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

        // POST: api/Viajes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Viaje>> PostViaje(Viaje viaje)
        {
            _context.Viaje.Add(viaje);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetViaje", new { id = viaje.idViaje }, viaje);
        }

        // DELETE: api/Viajes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Viaje>> DeleteViaje(int id)
        {
            var viaje = await _context.Viaje.FindAsync(id);
            if (viaje == null)
            {
                return NotFound();
            }

            _context.Viaje.Remove(viaje);
            await _context.SaveChangesAsync();

            return viaje;
        }

        private bool ViajeExists(int id)
        {
            return _context.Viaje.Any(e => e.idViaje == id);
        }
    }
}

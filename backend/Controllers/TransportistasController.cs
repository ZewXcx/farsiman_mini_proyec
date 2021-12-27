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
    public class TransportistasController : ControllerBase
    {
        private readonly TransportistaContext _context;

        public TransportistasController(TransportistaContext context)
        {
            _context = context;
        }

        // GET: api/Transportistas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transportista>>> GetTransportista()
        {
            return await _context.Transportista.ToListAsync();
        }

        // GET: api/Transportistas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transportista>> GetTransportista(int id)
        {
            var transportista = await _context.Transportista.FindAsync(id);

            if (transportista == null)
            {
                return NotFound();
            }

            return transportista;
        }

        // PUT: api/Transportistas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransportista(int id, Transportista transportista)
        {
            if (id != transportista.idTransportista)
            {
                return BadRequest();
            }

            _context.Entry(transportista).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransportistaExists(id))
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

        // POST: api/Transportistas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Transportista>> PostTransportista(Transportista transportista)
        {
            _context.Transportista.Add(transportista);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransportista", new { id = transportista.idTransportista }, transportista);
        }

        // DELETE: api/Transportistas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Transportista>> DeleteTransportista(int id)
        {
            var transportista = await _context.Transportista.FindAsync(id);
            if (transportista == null)
            {
                return NotFound();
            }

            _context.Transportista.Remove(transportista);
            await _context.SaveChangesAsync();

            return transportista;
        }

        private bool TransportistaExists(int id)
        {
            return _context.Transportista.Any(e => e.idTransportista == id);
        }
    }
}

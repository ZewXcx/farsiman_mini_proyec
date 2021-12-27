using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Viajes.Data;

namespace Viajes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Jefe_TiendaController : ControllerBase
    {
        private readonly Jefe_TiendaContext _context;

        public Jefe_TiendaController(Jefe_TiendaContext context)
        {
            _context = context;
        }

        // GET: api/Jefe_Tienda
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jefe_Tienda>>> GetJefe_Tienda()
        {
            return await _context.Jefe_Tienda.ToListAsync();
        }

        // GET: api/Jefe_Tienda/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jefe_Tienda>> GetJefe_Tienda(int id)
        {
            var jefe_Tienda = await _context.Jefe_Tienda.FindAsync(id);

            if (jefe_Tienda == null)
            {
                return NotFound();
            }

            return jefe_Tienda;
        }

        // PUT: api/Jefe_Tienda/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJefe_Tienda(int id, Jefe_Tienda jefe_Tienda)
        {
            if (id != jefe_Tienda.idJefe_Tienda)
            {
                return BadRequest();
            }

            _context.Entry(jefe_Tienda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Jefe_TiendaExists(id))
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

        // POST: api/Jefe_Tienda
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Jefe_Tienda>> PostJefe_Tienda(Jefe_Tienda jefe_Tienda)
        {
            _context.Jefe_Tienda.Add(jefe_Tienda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJefe_Tienda", new { id = jefe_Tienda.idJefe_Tienda }, jefe_Tienda);
        }

        // DELETE: api/Jefe_Tienda/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Jefe_Tienda>> DeleteJefe_Tienda(int id)
        {
            var jefe_Tienda = await _context.Jefe_Tienda.FindAsync(id);
            if (jefe_Tienda == null)
            {
                return NotFound();
            }

            _context.Jefe_Tienda.Remove(jefe_Tienda);
            await _context.SaveChangesAsync();

            return jefe_Tienda;
        }

        private bool Jefe_TiendaExists(int id)
        {
            return _context.Jefe_Tienda.Any(e => e.idJefe_Tienda == id);
        }
    }
}

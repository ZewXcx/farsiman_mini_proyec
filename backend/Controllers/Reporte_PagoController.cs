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
    public class Reporte_PagoController : ControllerBase
    {
        private readonly Reporte_PagoContext _context;

        public Reporte_PagoController(Reporte_PagoContext context)
        {
            _context = context;
        }

        // GET: api/Reporte_Pago
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reporte_Pago>>> GetReporte_Pago()
        {
            return await _context.Reporte_Pago.ToListAsync();
        }

        // GET: api/Reporte_Pago/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reporte_Pago>> GetReporte_Pago(int id)
        {
            var reporte_Pago = await _context.Reporte_Pago.FindAsync(id);

            if (reporte_Pago == null)
            {
                return NotFound();
            }

            return reporte_Pago;
        }

        // PUT: api/Reporte_Pago/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReporte_Pago(int id, Reporte_Pago reporte_Pago)
        {
            if (id != reporte_Pago.idReporte_Pago)
            {
                return BadRequest();
            }

            _context.Entry(reporte_Pago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Reporte_PagoExists(id))
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

        // POST: api/Reporte_Pago
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Reporte_Pago>> PostReporte_Pago(Reporte_Pago reporte_Pago)
        {
            _context.Reporte_Pago.Add(reporte_Pago);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReporte_Pago", new { id = reporte_Pago.idReporte_Pago }, reporte_Pago);
        }

        // DELETE: api/Reporte_Pago/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Reporte_Pago>> DeleteReporte_Pago(int id)
        {
            var reporte_Pago = await _context.Reporte_Pago.FindAsync(id);
            if (reporte_Pago == null)
            {
                return NotFound();
            }

            _context.Reporte_Pago.Remove(reporte_Pago);
            await _context.SaveChangesAsync();

            return reporte_Pago;
        }

        private bool Reporte_PagoExists(int id)
        {
            return _context.Reporte_Pago.Any(e => e.idReporte_Pago == id);
        }
    }
}

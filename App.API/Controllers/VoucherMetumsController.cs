using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Data.Models;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherMetumsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public VoucherMetumsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/VoucherMetums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoucherMetum>>> GetVoucherMeta()
        {
            return await _context.VoucherMeta.ToListAsync();
        }

        // GET: api/VoucherMetums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoucherMetum>> GetVoucherMetum(long id)
        {
            var voucherMetum = await _context.VoucherMeta.FindAsync(id);

            if (voucherMetum == null)
            {
                return NotFound();
            }

            return voucherMetum;
        }

        // PUT: api/VoucherMetums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVoucherMetum(long id, VoucherMetum voucherMetum)
        {
            if (id != voucherMetum.Id)
            {
                return BadRequest();
            }

            _context.Entry(voucherMetum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoucherMetumExists(id))
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

        // POST: api/VoucherMetums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VoucherMetum>> PostVoucherMetum(VoucherMetum voucherMetum)
        {
            _context.VoucherMeta.Add(voucherMetum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVoucherMetum", new { id = voucherMetum.Id }, voucherMetum);
        }

        // DELETE: api/VoucherMetums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoucherMetum(long id)
        {
            var voucherMetum = await _context.VoucherMeta.FindAsync(id);
            if (voucherMetum == null)
            {
                return NotFound();
            }

            _context.VoucherMeta.Remove(voucherMetum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VoucherMetumExists(long id)
        {
            return _context.VoucherMeta.Any(e => e.Id == id);
        }
    }
}

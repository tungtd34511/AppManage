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
    public class VoucherTypesController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public VoucherTypesController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/VoucherTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoucherType>>> GetVoucherTypes()
        {
            return await _context.VoucherTypes.ToListAsync();
        }

        // GET: api/VoucherTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoucherType>> GetVoucherType(long id)
        {
            var voucherType = await _context.VoucherTypes.FindAsync(id);

            if (voucherType == null)
            {
                return NotFound();
            }

            return voucherType;
        }

        // PUT: api/VoucherTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVoucherType(long id, VoucherType voucherType)
        {
            if (id != voucherType.Id)
            {
                return BadRequest();
            }

            _context.Entry(voucherType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoucherTypeExists(id))
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

        // POST: api/VoucherTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VoucherType>> PostVoucherType(VoucherType voucherType)
        {
            _context.VoucherTypes.Add(voucherType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVoucherType", new { id = voucherType.Id }, voucherType);
        }

        // DELETE: api/VoucherTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoucherType(long id)
        {
            var voucherType = await _context.VoucherTypes.FindAsync(id);
            if (voucherType == null)
            {
                return NotFound();
            }

            _context.VoucherTypes.Remove(voucherType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VoucherTypeExists(long id)
        {
            return _context.VoucherTypes.Any(e => e.Id == id);
        }
    }
}

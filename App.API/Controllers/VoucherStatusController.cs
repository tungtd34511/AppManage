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
    public class VoucherStatusController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public VoucherStatusController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/VoucherStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoucherStatus>>> GetVoucherStatuses()
        {
            return await _context.VoucherStatuses.ToListAsync();
        }

        // GET: api/VoucherStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoucherStatus>> GetVoucherStatus(long id)
        {
            var voucherStatus = await _context.VoucherStatuses.FindAsync(id);

            if (voucherStatus == null)
            {
                return NotFound();
            }

            return voucherStatus;
        }

        // PUT: api/VoucherStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVoucherStatus(long id, VoucherStatus voucherStatus)
        {
            if (id != voucherStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(voucherStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoucherStatusExists(id))
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

        // POST: api/VoucherStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VoucherStatus>> PostVoucherStatus(VoucherStatus voucherStatus)
        {
            _context.VoucherStatuses.Add(voucherStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVoucherStatus", new { id = voucherStatus.Id }, voucherStatus);
        }

        // DELETE: api/VoucherStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoucherStatus(long id)
        {
            var voucherStatus = await _context.VoucherStatuses.FindAsync(id);
            if (voucherStatus == null)
            {
                return NotFound();
            }

            _context.VoucherStatuses.Remove(voucherStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VoucherStatusExists(long id)
        {
            return _context.VoucherStatuses.Any(e => e.Id == id);
        }
    }
}

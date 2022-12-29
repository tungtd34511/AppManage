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
    public class ShopStatusController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public ShopStatusController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/ShopStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopStatus>>> GetShopStatuses()
        {
            return await _context.ShopStatuses.ToListAsync();
        }

        // GET: api/ShopStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopStatus>> GetShopStatus(long id)
        {
            var shopStatus = await _context.ShopStatuses.FindAsync(id);

            if (shopStatus == null)
            {
                return NotFound();
            }

            return shopStatus;
        }

        // PUT: api/ShopStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShopStatus(long id, ShopStatus shopStatus)
        {
            if (id != shopStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(shopStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopStatusExists(id))
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

        // POST: api/ShopStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShopStatus>> PostShopStatus(ShopStatus shopStatus)
        {
            _context.ShopStatuses.Add(shopStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShopStatus", new { id = shopStatus.Id }, shopStatus);
        }

        // DELETE: api/ShopStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShopStatus(long id)
        {
            var shopStatus = await _context.ShopStatuses.FindAsync(id);
            if (shopStatus == null)
            {
                return NotFound();
            }

            _context.ShopStatuses.Remove(shopStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShopStatusExists(long id)
        {
            return _context.ShopStatuses.Any(e => e.Id == id);
        }
    }
}

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
    public class ShopMetumsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public ShopMetumsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/ShopMetums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopMetum>>> GetShopMeta()
        {
            return await _context.ShopMeta.ToListAsync();
        }

        // GET: api/ShopMetums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopMetum>> GetShopMetum(long id)
        {
            var shopMetum = await _context.ShopMeta.FindAsync(id);

            if (shopMetum == null)
            {
                return NotFound();
            }

            return shopMetum;
        }

        // PUT: api/ShopMetums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShopMetum(long id, ShopMetum shopMetum)
        {
            if (id != shopMetum.Id)
            {
                return BadRequest();
            }

            _context.Entry(shopMetum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopMetumExists(id))
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

        // POST: api/ShopMetums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShopMetum>> PostShopMetum(ShopMetum shopMetum)
        {
            _context.ShopMeta.Add(shopMetum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShopMetum", new { id = shopMetum.Id }, shopMetum);
        }

        // DELETE: api/ShopMetums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShopMetum(long id)
        {
            var shopMetum = await _context.ShopMeta.FindAsync(id);
            if (shopMetum == null)
            {
                return NotFound();
            }

            _context.ShopMeta.Remove(shopMetum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShopMetumExists(long id)
        {
            return _context.ShopMeta.Any(e => e.Id == id);
        }
    }
}

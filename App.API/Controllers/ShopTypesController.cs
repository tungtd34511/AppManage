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
    public class ShopTypesController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public ShopTypesController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/ShopTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopType>>> GetShopTypes()
        {
            return await _context.ShopTypes.ToListAsync();
        }

        // GET: api/ShopTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopType>> GetShopType(long id)
        {
            var shopType = await _context.ShopTypes.FindAsync(id);

            if (shopType == null)
            {
                return NotFound();
            }

            return shopType;
        }

        // PUT: api/ShopTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShopType(long id, ShopType shopType)
        {
            if (id != shopType.Id)
            {
                return BadRequest();
            }

            _context.Entry(shopType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopTypeExists(id))
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

        // POST: api/ShopTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShopType>> PostShopType(ShopType shopType)
        {
            _context.ShopTypes.Add(shopType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShopType", new { id = shopType.Id }, shopType);
        }

        // DELETE: api/ShopTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShopType(long id)
        {
            var shopType = await _context.ShopTypes.FindAsync(id);
            if (shopType == null)
            {
                return NotFound();
            }

            _context.ShopTypes.Remove(shopType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShopTypeExists(long id)
        {
            return _context.ShopTypes.Any(e => e.Id == id);
        }
    }
}

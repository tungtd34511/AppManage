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
    public class ShopProductsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public ShopProductsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/ShopProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopProduct>>> GetShopProducts()
        {
            return await _context.ShopProducts.ToListAsync();
        }

        // GET: api/ShopProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopProduct>> GetShopProduct(long id)
        {
            var shopProduct = await _context.ShopProducts.FindAsync(id);

            if (shopProduct == null)
            {
                return NotFound();
            }

            return shopProduct;
        }

        // PUT: api/ShopProducts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShopProduct(long id, ShopProduct shopProduct)
        {
            if (id != shopProduct.ShopId)
            {
                return BadRequest();
            }

            _context.Entry(shopProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopProductExists(id))
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

        // POST: api/ShopProducts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShopProduct>> PostShopProduct(ShopProduct shopProduct)
        {
            _context.ShopProducts.Add(shopProduct);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ShopProductExists(shopProduct.ShopId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetShopProduct", new { id = shopProduct.ShopId }, shopProduct);
        }

        // DELETE: api/ShopProducts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShopProduct(long id)
        {
            var shopProduct = await _context.ShopProducts.FindAsync(id);
            if (shopProduct == null)
            {
                return NotFound();
            }

            _context.ShopProducts.Remove(shopProduct);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShopProductExists(long id)
        {
            return _context.ShopProducts.Any(e => e.ShopId == id);
        }
    }
}

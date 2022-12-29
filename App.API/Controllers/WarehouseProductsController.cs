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
    public class WarehouseProductsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public WarehouseProductsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/WarehouseProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WarehouseProduct>>> GetWarehouseProducts()
        {
            return await _context.WarehouseProducts.ToListAsync();
        }

        // GET: api/WarehouseProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WarehouseProduct>> GetWarehouseProduct(long id)
        {
            var warehouseProduct = await _context.WarehouseProducts.FindAsync(id);

            if (warehouseProduct == null)
            {
                return NotFound();
            }

            return warehouseProduct;
        }

        // PUT: api/WarehouseProducts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWarehouseProduct(long id, WarehouseProduct warehouseProduct)
        {
            if (id != warehouseProduct.Id)
            {
                return BadRequest();
            }

            _context.Entry(warehouseProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WarehouseProductExists(id))
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

        // POST: api/WarehouseProducts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WarehouseProduct>> PostWarehouseProduct(WarehouseProduct warehouseProduct)
        {
            _context.WarehouseProducts.Add(warehouseProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWarehouseProduct", new { id = warehouseProduct.Id }, warehouseProduct);
        }

        // DELETE: api/WarehouseProducts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWarehouseProduct(long id)
        {
            var warehouseProduct = await _context.WarehouseProducts.FindAsync(id);
            if (warehouseProduct == null)
            {
                return NotFound();
            }

            _context.WarehouseProducts.Remove(warehouseProduct);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WarehouseProductExists(long id)
        {
            return _context.WarehouseProducts.Any(e => e.Id == id);
        }
    }
}

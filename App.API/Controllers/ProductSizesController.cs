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
    public class ProductSizesController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public ProductSizesController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/ProductSizes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductSize>>> GetProductSizes()
        {
            return await _context.ProductSizes.ToListAsync();
        }

        // GET: api/ProductSizes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductSize>> GetProductSize(long id)
        {
            var productSize = await _context.ProductSizes.FindAsync(id);

            if (productSize == null)
            {
                return NotFound();
            }

            return productSize;
        }

        // PUT: api/ProductSizes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductSize(long id, ProductSize productSize)
        {
            if (id != productSize.Id)
            {
                return BadRequest();
            }

            _context.Entry(productSize).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductSizeExists(id))
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

        // POST: api/ProductSizes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductSize>> PostProductSize(ProductSize productSize)
        {
            _context.ProductSizes.Add(productSize);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductSize", new { id = productSize.Id }, productSize);
        }

        // DELETE: api/ProductSizes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductSize(long id)
        {
            var productSize = await _context.ProductSizes.FindAsync(id);
            if (productSize == null)
            {
                return NotFound();
            }

            _context.ProductSizes.Remove(productSize);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductSizeExists(long id)
        {
            return _context.ProductSizes.Any(e => e.Id == id);
        }
    }
}

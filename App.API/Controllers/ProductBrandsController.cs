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
    public class ProductBrandsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public ProductBrandsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/ProductBrands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductBrand>>> GetProductBrands()
        {
            return await _context.ProductBrands.ToListAsync();
        }

        // GET: api/ProductBrands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductBrand>> GetProductBrand(long id)
        {
            var productBrand = await _context.ProductBrands.FindAsync(id);

            if (productBrand == null)
            {
                return NotFound();
            }

            return productBrand;
        }

        // PUT: api/ProductBrands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductBrand(long id, ProductBrand productBrand)
        {
            if (id != productBrand.Id)
            {
                return BadRequest();
            }

            _context.Entry(productBrand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductBrandExists(id))
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

        // POST: api/ProductBrands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductBrand>> PostProductBrand(ProductBrand productBrand)
        {
            _context.ProductBrands.Add(productBrand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductBrand", new { id = productBrand.Id }, productBrand);
        }

        // DELETE: api/ProductBrands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductBrand(long id)
        {
            var productBrand = await _context.ProductBrands.FindAsync(id);
            if (productBrand == null)
            {
                return NotFound();
            }

            _context.ProductBrands.Remove(productBrand);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductBrandExists(long id)
        {
            return _context.ProductBrands.Any(e => e.Id == id);
        }
    }
}

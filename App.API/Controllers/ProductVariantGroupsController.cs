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
    public class ProductVariantGroupsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public ProductVariantGroupsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/ProductVariantGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVariantGroup>>> GetProductVariantGroups()
        {
            return await _context.ProductVariantGroups.ToListAsync();
        }

        // GET: api/ProductVariantGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVariantGroup>> GetProductVariantGroup(long id)
        {
            var productVariantGroup = await _context.ProductVariantGroups.FindAsync(id);

            if (productVariantGroup == null)
            {
                return NotFound();
            }

            return productVariantGroup;
        }

        // PUT: api/ProductVariantGroups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductVariantGroup(long id, ProductVariantGroup productVariantGroup)
        {
            if (id != productVariantGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(productVariantGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductVariantGroupExists(id))
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

        // POST: api/ProductVariantGroups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductVariantGroup>> PostProductVariantGroup(ProductVariantGroup productVariantGroup)
        {
            _context.ProductVariantGroups.Add(productVariantGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductVariantGroup", new { id = productVariantGroup.Id }, productVariantGroup);
        }

        // DELETE: api/ProductVariantGroups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductVariantGroup(long id)
        {
            var productVariantGroup = await _context.ProductVariantGroups.FindAsync(id);
            if (productVariantGroup == null)
            {
                return NotFound();
            }

            _context.ProductVariantGroups.Remove(productVariantGroup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductVariantGroupExists(long id)
        {
            return _context.ProductVariantGroups.Any(e => e.Id == id);
        }
    }
}

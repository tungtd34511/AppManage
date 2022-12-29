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
    public class ProductUnitsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public ProductUnitsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/ProductUnits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductUnit>>> GetProductUnits()
        {
            return await _context.ProductUnits.ToListAsync();
        }

        // GET: api/ProductUnits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductUnit>> GetProductUnit(long id)
        {
            var productUnit = await _context.ProductUnits.FindAsync(id);

            if (productUnit == null)
            {
                return NotFound();
            }

            return productUnit;
        }

        // PUT: api/ProductUnits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductUnit(long id, ProductUnit productUnit)
        {
            if (id != productUnit.Id)
            {
                return BadRequest();
            }

            _context.Entry(productUnit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductUnitExists(id))
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

        // POST: api/ProductUnits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductUnit>> PostProductUnit(ProductUnit productUnit)
        {
            _context.ProductUnits.Add(productUnit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductUnit", new { id = productUnit.Id }, productUnit);
        }

        // DELETE: api/ProductUnits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductUnit(long id)
        {
            var productUnit = await _context.ProductUnits.FindAsync(id);
            if (productUnit == null)
            {
                return NotFound();
            }

            _context.ProductUnits.Remove(productUnit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductUnitExists(long id)
        {
            return _context.ProductUnits.Any(e => e.Id == id);
        }
    }
}

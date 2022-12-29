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
    public class CustomerCategoriesController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public CustomerCategoriesController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/CustomerCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerCategory>>> GetCustomerCategories()
        {
            return await _context.CustomerCategories.ToListAsync();
        }

        // GET: api/CustomerCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerCategory>> GetCustomerCategory(long id)
        {
            var customerCategory = await _context.CustomerCategories.FindAsync(id);

            if (customerCategory == null)
            {
                return NotFound();
            }

            return customerCategory;
        }

        // PUT: api/CustomerCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerCategory(long id, CustomerCategory customerCategory)
        {
            if (id != customerCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(customerCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerCategoryExists(id))
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

        // POST: api/CustomerCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerCategory>> PostCustomerCategory(CustomerCategory customerCategory)
        {
            _context.CustomerCategories.Add(customerCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerCategory", new { id = customerCategory.Id }, customerCategory);
        }

        // DELETE: api/CustomerCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerCategory(long id)
        {
            var customerCategory = await _context.CustomerCategories.FindAsync(id);
            if (customerCategory == null)
            {
                return NotFound();
            }

            _context.CustomerCategories.Remove(customerCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerCategoryExists(long id)
        {
            return _context.CustomerCategories.Any(e => e.Id == id);
        }
    }
}

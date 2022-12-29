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
    public class FeaturedPostTypesController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public FeaturedPostTypesController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/FeaturedPostTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FeaturedPostType>>> GetFeaturedPostTypes()
        {
            return await _context.FeaturedPostTypes.ToListAsync();
        }

        // GET: api/FeaturedPostTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FeaturedPostType>> GetFeaturedPostType(long id)
        {
            var featuredPostType = await _context.FeaturedPostTypes.FindAsync(id);

            if (featuredPostType == null)
            {
                return NotFound();
            }

            return featuredPostType;
        }

        // PUT: api/FeaturedPostTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeaturedPostType(long id, FeaturedPostType featuredPostType)
        {
            if (id != featuredPostType.Id)
            {
                return BadRequest();
            }

            _context.Entry(featuredPostType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeaturedPostTypeExists(id))
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

        // POST: api/FeaturedPostTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FeaturedPostType>> PostFeaturedPostType(FeaturedPostType featuredPostType)
        {
            _context.FeaturedPostTypes.Add(featuredPostType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFeaturedPostType", new { id = featuredPostType.Id }, featuredPostType);
        }

        // DELETE: api/FeaturedPostTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeaturedPostType(long id)
        {
            var featuredPostType = await _context.FeaturedPostTypes.FindAsync(id);
            if (featuredPostType == null)
            {
                return NotFound();
            }

            _context.FeaturedPostTypes.Remove(featuredPostType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FeaturedPostTypeExists(long id)
        {
            return _context.FeaturedPostTypes.Any(e => e.Id == id);
        }
    }
}

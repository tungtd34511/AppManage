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
    public class PromotionMetumsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public PromotionMetumsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/PromotionMetums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PromotionMetum>>> GetPromotionMeta()
        {
            return await _context.PromotionMeta.ToListAsync();
        }

        // GET: api/PromotionMetums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PromotionMetum>> GetPromotionMetum(long id)
        {
            var promotionMetum = await _context.PromotionMeta.FindAsync(id);

            if (promotionMetum == null)
            {
                return NotFound();
            }

            return promotionMetum;
        }

        // PUT: api/PromotionMetums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPromotionMetum(long id, PromotionMetum promotionMetum)
        {
            if (id != promotionMetum.Id)
            {
                return BadRequest();
            }

            _context.Entry(promotionMetum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PromotionMetumExists(id))
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

        // POST: api/PromotionMetums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PromotionMetum>> PostPromotionMetum(PromotionMetum promotionMetum)
        {
            _context.PromotionMeta.Add(promotionMetum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPromotionMetum", new { id = promotionMetum.Id }, promotionMetum);
        }

        // DELETE: api/PromotionMetums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePromotionMetum(long id)
        {
            var promotionMetum = await _context.PromotionMeta.FindAsync(id);
            if (promotionMetum == null)
            {
                return NotFound();
            }

            _context.PromotionMeta.Remove(promotionMetum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PromotionMetumExists(long id)
        {
            return _context.PromotionMeta.Any(e => e.Id == id);
        }
    }
}

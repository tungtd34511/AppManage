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
    public class PostLayoutsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public PostLayoutsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/PostLayouts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostLayout>>> GetPostLayouts()
        {
            return await _context.PostLayouts.ToListAsync();
        }

        // GET: api/PostLayouts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostLayout>> GetPostLayout(long id)
        {
            var postLayout = await _context.PostLayouts.FindAsync(id);

            if (postLayout == null)
            {
                return NotFound();
            }

            return postLayout;
        }

        // PUT: api/PostLayouts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostLayout(long id, PostLayout postLayout)
        {
            if (id != postLayout.Id)
            {
                return BadRequest();
            }

            _context.Entry(postLayout).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostLayoutExists(id))
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

        // POST: api/PostLayouts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PostLayout>> PostPostLayout(PostLayout postLayout)
        {
            _context.PostLayouts.Add(postLayout);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostLayout", new { id = postLayout.Id }, postLayout);
        }

        // DELETE: api/PostLayouts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostLayout(long id)
        {
            var postLayout = await _context.PostLayouts.FindAsync(id);
            if (postLayout == null)
            {
                return NotFound();
            }

            _context.PostLayouts.Remove(postLayout);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostLayoutExists(long id)
        {
            return _context.PostLayouts.Any(e => e.Id == id);
        }
    }
}

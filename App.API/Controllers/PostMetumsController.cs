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
    public class PostMetumsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public PostMetumsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/PostMetums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostMetum>>> GetPostMeta()
        {
            return await _context.PostMeta.ToListAsync();
        }

        // GET: api/PostMetums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostMetum>> GetPostMetum(long id)
        {
            var postMetum = await _context.PostMeta.FindAsync(id);

            if (postMetum == null)
            {
                return NotFound();
            }

            return postMetum;
        }

        // PUT: api/PostMetums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostMetum(long id, PostMetum postMetum)
        {
            if (id != postMetum.Id)
            {
                return BadRequest();
            }

            _context.Entry(postMetum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostMetumExists(id))
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

        // POST: api/PostMetums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PostMetum>> PostPostMetum(PostMetum postMetum)
        {
            _context.PostMeta.Add(postMetum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostMetum", new { id = postMetum.Id }, postMetum);
        }

        // DELETE: api/PostMetums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostMetum(long id)
        {
            var postMetum = await _context.PostMeta.FindAsync(id);
            if (postMetum == null)
            {
                return NotFound();
            }

            _context.PostMeta.Remove(postMetum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostMetumExists(long id)
        {
            return _context.PostMeta.Any(e => e.Id == id);
        }
    }
}

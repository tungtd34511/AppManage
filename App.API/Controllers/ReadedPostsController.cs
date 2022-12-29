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
    public class ReadedPostsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public ReadedPostsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/ReadedPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadedPost>>> GetReadedPosts()
        {
            return await _context.ReadedPosts.ToListAsync();
        }

        // GET: api/ReadedPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadedPost>> GetReadedPost(long id)
        {
            var readedPost = await _context.ReadedPosts.FindAsync(id);

            if (readedPost == null)
            {
                return NotFound();
            }

            return readedPost;
        }

        // PUT: api/ReadedPosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReadedPost(long id, ReadedPost readedPost)
        {
            if (id != readedPost.Id)
            {
                return BadRequest();
            }

            _context.Entry(readedPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReadedPostExists(id))
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

        // POST: api/ReadedPosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReadedPost>> PostReadedPost(ReadedPost readedPost)
        {
            _context.ReadedPosts.Add(readedPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReadedPost", new { id = readedPost.Id }, readedPost);
        }

        // DELETE: api/ReadedPosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReadedPost(long id)
        {
            var readedPost = await _context.ReadedPosts.FindAsync(id);
            if (readedPost == null)
            {
                return NotFound();
            }

            _context.ReadedPosts.Remove(readedPost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReadedPostExists(long id)
        {
            return _context.ReadedPosts.Any(e => e.Id == id);
        }
    }
}

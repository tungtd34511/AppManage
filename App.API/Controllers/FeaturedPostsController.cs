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
    public class FeaturedPostsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public FeaturedPostsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/FeaturedPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FeaturedPost>>> GetFeaturedPosts()
        {
            return await _context.FeaturedPosts.ToListAsync();
        }

        // GET: api/FeaturedPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FeaturedPost>> GetFeaturedPost(long id)
        {
            var featuredPost = await _context.FeaturedPosts.FindAsync(id);

            if (featuredPost == null)
            {
                return NotFound();
            }

            return featuredPost;
        }

        // PUT: api/FeaturedPosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeaturedPost(long id, FeaturedPost featuredPost)
        {
            if (id != featuredPost.Id)
            {
                return BadRequest();
            }

            _context.Entry(featuredPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeaturedPostExists(id))
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

        // POST: api/FeaturedPosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FeaturedPost>> PostFeaturedPost(FeaturedPost featuredPost)
        {
            _context.FeaturedPosts.Add(featuredPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFeaturedPost", new { id = featuredPost.Id }, featuredPost);
        }

        // DELETE: api/FeaturedPosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeaturedPost(long id)
        {
            var featuredPost = await _context.FeaturedPosts.FindAsync(id);
            if (featuredPost == null)
            {
                return NotFound();
            }

            _context.FeaturedPosts.Remove(featuredPost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FeaturedPostExists(long id)
        {
            return _context.FeaturedPosts.Any(e => e.Id == id);
        }
    }
}

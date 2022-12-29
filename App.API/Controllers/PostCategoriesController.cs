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
    public class PostCategoriesController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public PostCategoriesController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/PostCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostCategory>>> GetPostCategories()
        {
            return await _context.PostCategories.ToListAsync();
        }

        // GET: api/PostCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostCategory>> GetPostCategory(long id)
        {
            var postCategory = await _context.PostCategories.FindAsync(id);

            if (postCategory == null)
            {
                return NotFound();
            }

            return postCategory;
        }

        // PUT: api/PostCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostCategory(long id, PostCategory postCategory)
        {
            if (id != postCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(postCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostCategoryExists(id))
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

        // POST: api/PostCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PostCategory>> PostPostCategory(PostCategory postCategory)
        {
            _context.PostCategories.Add(postCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostCategory", new { id = postCategory.Id }, postCategory);
        }

        // DELETE: api/PostCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostCategory(long id)
        {
            var postCategory = await _context.PostCategories.FindAsync(id);
            if (postCategory == null)
            {
                return NotFound();
            }

            _context.PostCategories.Remove(postCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostCategoryExists(long id)
        {
            return _context.PostCategories.Any(e => e.Id == id);
        }
    }
}

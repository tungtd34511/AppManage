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
    public class PostTypesController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public PostTypesController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/PostTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostType>>> GetPostTypes()
        {
            return await _context.PostTypes.ToListAsync();
        }

        // GET: api/PostTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostType>> GetPostType(long id)
        {
            var postType = await _context.PostTypes.FindAsync(id);

            if (postType == null)
            {
                return NotFound();
            }

            return postType;
        }

        // PUT: api/PostTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostType(long id, PostType postType)
        {
            if (id != postType.Id)
            {
                return BadRequest();
            }

            _context.Entry(postType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostTypeExists(id))
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

        // POST: api/PostTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PostType>> PostPostType(PostType postType)
        {
            _context.PostTypes.Add(postType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostType", new { id = postType.Id }, postType);
        }

        // DELETE: api/PostTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostType(long id)
        {
            var postType = await _context.PostTypes.FindAsync(id);
            if (postType == null)
            {
                return NotFound();
            }

            _context.PostTypes.Remove(postType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostTypeExists(long id)
        {
            return _context.PostTypes.Any(e => e.Id == id);
        }
    }
}

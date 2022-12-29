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
    public class PostTopicsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public PostTopicsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/PostTopics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostTopic>>> GetPostTopics()
        {
            return await _context.PostTopics.ToListAsync();
        }

        // GET: api/PostTopics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostTopic>> GetPostTopic(long id)
        {
            var postTopic = await _context.PostTopics.FindAsync(id);

            if (postTopic == null)
            {
                return NotFound();
            }

            return postTopic;
        }

        // PUT: api/PostTopics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostTopic(long id, PostTopic postTopic)
        {
            if (id != postTopic.Id)
            {
                return BadRequest();
            }

            _context.Entry(postTopic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostTopicExists(id))
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

        // POST: api/PostTopics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PostTopic>> PostPostTopic(PostTopic postTopic)
        {
            _context.PostTopics.Add(postTopic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostTopic", new { id = postTopic.Id }, postTopic);
        }

        // DELETE: api/PostTopics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostTopic(long id)
        {
            var postTopic = await _context.PostTopics.FindAsync(id);
            if (postTopic == null)
            {
                return NotFound();
            }

            _context.PostTopics.Remove(postTopic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostTopicExists(long id)
        {
            return _context.PostTopics.Any(e => e.Id == id);
        }
    }
}

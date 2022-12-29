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
    public class PostPublishStatusController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public PostPublishStatusController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/PostPublishStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostPublishStatus>>> GetPostPublishStatuses()
        {
            return await _context.PostPublishStatuses.ToListAsync();
        }

        // GET: api/PostPublishStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostPublishStatus>> GetPostPublishStatus(long id)
        {
            var postPublishStatus = await _context.PostPublishStatuses.FindAsync(id);

            if (postPublishStatus == null)
            {
                return NotFound();
            }

            return postPublishStatus;
        }

        // PUT: api/PostPublishStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostPublishStatus(long id, PostPublishStatus postPublishStatus)
        {
            if (id != postPublishStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(postPublishStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostPublishStatusExists(id))
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

        // POST: api/PostPublishStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PostPublishStatus>> PostPostPublishStatus(PostPublishStatus postPublishStatus)
        {
            _context.PostPublishStatuses.Add(postPublishStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostPublishStatus", new { id = postPublishStatus.Id }, postPublishStatus);
        }

        // DELETE: api/PostPublishStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostPublishStatus(long id)
        {
            var postPublishStatus = await _context.PostPublishStatuses.FindAsync(id);
            if (postPublishStatus == null)
            {
                return NotFound();
            }

            _context.PostPublishStatuses.Remove(postPublishStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostPublishStatusExists(long id)
        {
            return _context.PostPublishStatuses.Any(e => e.Id == id);
        }
    }
}

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
    public class PostCommentStatusController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public PostCommentStatusController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/PostCommentStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostCommentStatus>>> GetPostCommentStatuses()
        {
            return await _context.PostCommentStatuses.ToListAsync();
        }

        // GET: api/PostCommentStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostCommentStatus>> GetPostCommentStatus(long id)
        {
            var postCommentStatus = await _context.PostCommentStatuses.FindAsync(id);

            if (postCommentStatus == null)
            {
                return NotFound();
            }

            return postCommentStatus;
        }

        // PUT: api/PostCommentStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostCommentStatus(long id, PostCommentStatus postCommentStatus)
        {
            if (id != postCommentStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(postCommentStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostCommentStatusExists(id))
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

        // POST: api/PostCommentStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PostCommentStatus>> PostPostCommentStatus(PostCommentStatus postCommentStatus)
        {
            _context.PostCommentStatuses.Add(postCommentStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostCommentStatus", new { id = postCommentStatus.Id }, postCommentStatus);
        }

        // DELETE: api/PostCommentStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostCommentStatus(long id)
        {
            var postCommentStatus = await _context.PostCommentStatuses.FindAsync(id);
            if (postCommentStatus == null)
            {
                return NotFound();
            }

            _context.PostCommentStatuses.Remove(postCommentStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostCommentStatusExists(long id)
        {
            return _context.PostCommentStatuses.Any(e => e.Id == id);
        }
    }
}

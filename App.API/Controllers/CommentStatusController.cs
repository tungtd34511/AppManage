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
    public class CommentStatusController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public CommentStatusController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/CommentStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentStatus>>> GetCommentStatuses()
        {
            return await _context.CommentStatuses.ToListAsync();
        }

        // GET: api/CommentStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommentStatus>> GetCommentStatus(long id)
        {
            var commentStatus = await _context.CommentStatuses.FindAsync(id);

            if (commentStatus == null)
            {
                return NotFound();
            }

            return commentStatus;
        }

        // PUT: api/CommentStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommentStatus(long id, CommentStatus commentStatus)
        {
            if (id != commentStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(commentStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentStatusExists(id))
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

        // POST: api/CommentStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CommentStatus>> PostCommentStatus(CommentStatus commentStatus)
        {
            _context.CommentStatuses.Add(commentStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommentStatus", new { id = commentStatus.Id }, commentStatus);
        }

        // DELETE: api/CommentStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommentStatus(long id)
        {
            var commentStatus = await _context.CommentStatuses.FindAsync(id);
            if (commentStatus == null)
            {
                return NotFound();
            }

            _context.CommentStatuses.Remove(commentStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommentStatusExists(long id)
        {
            return _context.CommentStatuses.Any(e => e.Id == id);
        }
    }
}

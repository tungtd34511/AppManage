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
    public class TransactionMetumsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public TransactionMetumsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/TransactionMetums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionMetum>>> GetTransactionMeta()
        {
            return await _context.TransactionMeta.ToListAsync();
        }

        // GET: api/TransactionMetums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionMetum>> GetTransactionMetum(long id)
        {
            var transactionMetum = await _context.TransactionMeta.FindAsync(id);

            if (transactionMetum == null)
            {
                return NotFound();
            }

            return transactionMetum;
        }

        // PUT: api/TransactionMetums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransactionMetum(long id, TransactionMetum transactionMetum)
        {
            if (id != transactionMetum.Id)
            {
                return BadRequest();
            }

            _context.Entry(transactionMetum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionMetumExists(id))
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

        // POST: api/TransactionMetums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TransactionMetum>> PostTransactionMetum(TransactionMetum transactionMetum)
        {
            _context.TransactionMeta.Add(transactionMetum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransactionMetum", new { id = transactionMetum.Id }, transactionMetum);
        }

        // DELETE: api/TransactionMetums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransactionMetum(long id)
        {
            var transactionMetum = await _context.TransactionMeta.FindAsync(id);
            if (transactionMetum == null)
            {
                return NotFound();
            }

            _context.TransactionMeta.Remove(transactionMetum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TransactionMetumExists(long id)
        {
            return _context.TransactionMeta.Any(e => e.Id == id);
        }
    }
}

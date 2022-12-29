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
    public class TransactionStatusController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public TransactionStatusController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/TransactionStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionStatus>>> GetTransactionStatuses()
        {
            return await _context.TransactionStatuses.ToListAsync();
        }

        // GET: api/TransactionStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionStatus>> GetTransactionStatus(long id)
        {
            var transactionStatus = await _context.TransactionStatuses.FindAsync(id);

            if (transactionStatus == null)
            {
                return NotFound();
            }

            return transactionStatus;
        }

        // PUT: api/TransactionStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransactionStatus(long id, TransactionStatus transactionStatus)
        {
            if (id != transactionStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(transactionStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionStatusExists(id))
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

        // POST: api/TransactionStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TransactionStatus>> PostTransactionStatus(TransactionStatus transactionStatus)
        {
            _context.TransactionStatuses.Add(transactionStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransactionStatus", new { id = transactionStatus.Id }, transactionStatus);
        }

        // DELETE: api/TransactionStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransactionStatus(long id)
        {
            var transactionStatus = await _context.TransactionStatuses.FindAsync(id);
            if (transactionStatus == null)
            {
                return NotFound();
            }

            _context.TransactionStatuses.Remove(transactionStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TransactionStatusExists(long id)
        {
            return _context.TransactionStatuses.Any(e => e.Id == id);
        }
    }
}

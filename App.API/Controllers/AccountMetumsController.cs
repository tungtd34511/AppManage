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
    public class AccountMetumsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public AccountMetumsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/AccountMetums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountMetum>>> GetAccountMeta()
        {
            return await _context.AccountMeta.ToListAsync();
        }

        // GET: api/AccountMetums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccountMetum>> GetAccountMetum(long id)
        {
            var accountMetum = await _context.AccountMeta.FindAsync(id);

            if (accountMetum == null)
            {
                return NotFound();
            }

            return accountMetum;
        }

        // PUT: api/AccountMetums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccountMetum(long id, AccountMetum accountMetum)
        {
            if (id != accountMetum.Id)
            {
                return BadRequest();
            }

            _context.Entry(accountMetum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountMetumExists(id))
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

        // POST: api/AccountMetums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AccountMetum>> PostAccountMetum(AccountMetum accountMetum)
        {
            _context.AccountMeta.Add(accountMetum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccountMetum", new { id = accountMetum.Id }, accountMetum);
        }

        // DELETE: api/AccountMetums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccountMetum(long id)
        {
            var accountMetum = await _context.AccountMeta.FindAsync(id);
            if (accountMetum == null)
            {
                return NotFound();
            }

            _context.AccountMeta.Remove(accountMetum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccountMetumExists(long id)
        {
            return _context.AccountMeta.Any(e => e.Id == id);
        }
    }
}

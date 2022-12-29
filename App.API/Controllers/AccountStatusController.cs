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
    public class AccountStatusController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public AccountStatusController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/AccountStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountStatus>>> GetAccountStatuses()
        {
            return await _context.AccountStatuses.ToListAsync();
        }

        // GET: api/AccountStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccountStatus>> GetAccountStatus(long id)
        {
            var accountStatus = await _context.AccountStatuses.FindAsync(id);

            if (accountStatus == null)
            {
                return NotFound();
            }

            return accountStatus;
        }

        // PUT: api/AccountStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccountStatus(long id, AccountStatus accountStatus)
        {
            if (id != accountStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(accountStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountStatusExists(id))
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

        // POST: api/AccountStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AccountStatus>> PostAccountStatus(AccountStatus accountStatus)
        {
            _context.AccountStatuses.Add(accountStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccountStatus", new { id = accountStatus.Id }, accountStatus);
        }

        // DELETE: api/AccountStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccountStatus(long id)
        {
            var accountStatus = await _context.AccountStatuses.FindAsync(id);
            if (accountStatus == null)
            {
                return NotFound();
            }

            _context.AccountStatuses.Remove(accountStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccountStatusExists(long id)
        {
            return _context.AccountStatuses.Any(e => e.Id == id);
        }
    }
}

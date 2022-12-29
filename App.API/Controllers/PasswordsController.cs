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
    public class PasswordsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public PasswordsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/Passwords
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Password>>> GetPasswords()
        {
            return await _context.Passwords.ToListAsync();
        }

        // GET: api/Passwords/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Password>> GetPassword(long id)
        {
            var password = await _context.Passwords.FindAsync(id);

            if (password == null)
            {
                return NotFound();
            }

            return password;
        }

        // PUT: api/Passwords/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPassword(long id, Password password)
        {
            if (id != password.Id)
            {
                return BadRequest();
            }

            _context.Entry(password).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PasswordExists(id))
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

        // POST: api/Passwords
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Password>> PostPassword(Password password)
        {
            _context.Passwords.Add(password);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPassword", new { id = password.Id }, password);
        }

        // DELETE: api/Passwords/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePassword(long id)
        {
            var password = await _context.Passwords.FindAsync(id);
            if (password == null)
            {
                return NotFound();
            }

            _context.Passwords.Remove(password);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PasswordExists(long id)
        {
            return _context.Passwords.Any(e => e.Id == id);
        }
    }
}

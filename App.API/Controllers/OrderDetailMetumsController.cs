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
    public class OrderDetailMetumsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public OrderDetailMetumsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/OrderDetailMetums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetailMetum>>> GetOrderDetailMeta()
        {
            return await _context.OrderDetailMeta.ToListAsync();
        }

        // GET: api/OrderDetailMetums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetailMetum>> GetOrderDetailMetum(long id)
        {
            var orderDetailMetum = await _context.OrderDetailMeta.FindAsync(id);

            if (orderDetailMetum == null)
            {
                return NotFound();
            }

            return orderDetailMetum;
        }

        // PUT: api/OrderDetailMetums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderDetailMetum(long id, OrderDetailMetum orderDetailMetum)
        {
            if (id != orderDetailMetum.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderDetailMetum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderDetailMetumExists(id))
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

        // POST: api/OrderDetailMetums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderDetailMetum>> PostOrderDetailMetum(OrderDetailMetum orderDetailMetum)
        {
            _context.OrderDetailMeta.Add(orderDetailMetum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderDetailMetum", new { id = orderDetailMetum.Id }, orderDetailMetum);
        }

        // DELETE: api/OrderDetailMetums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetailMetum(long id)
        {
            var orderDetailMetum = await _context.OrderDetailMeta.FindAsync(id);
            if (orderDetailMetum == null)
            {
                return NotFound();
            }

            _context.OrderDetailMeta.Remove(orderDetailMetum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderDetailMetumExists(long id)
        {
            return _context.OrderDetailMeta.Any(e => e.Id == id);
        }
    }
}

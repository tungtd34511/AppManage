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
    public class OrderPaymentStatusController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public OrderPaymentStatusController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/OrderPaymentStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderPaymentStatus>>> GetOrderPaymentStatuses()
        {
            return await _context.OrderPaymentStatuses.ToListAsync();
        }

        // GET: api/OrderPaymentStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderPaymentStatus>> GetOrderPaymentStatus(long id)
        {
            var orderPaymentStatus = await _context.OrderPaymentStatuses.FindAsync(id);

            if (orderPaymentStatus == null)
            {
                return NotFound();
            }

            return orderPaymentStatus;
        }

        // PUT: api/OrderPaymentStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderPaymentStatus(long id, OrderPaymentStatus orderPaymentStatus)
        {
            if (id != orderPaymentStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderPaymentStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderPaymentStatusExists(id))
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

        // POST: api/OrderPaymentStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderPaymentStatus>> PostOrderPaymentStatus(OrderPaymentStatus orderPaymentStatus)
        {
            _context.OrderPaymentStatuses.Add(orderPaymentStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderPaymentStatus", new { id = orderPaymentStatus.Id }, orderPaymentStatus);
        }

        // DELETE: api/OrderPaymentStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderPaymentStatus(long id)
        {
            var orderPaymentStatus = await _context.OrderPaymentStatuses.FindAsync(id);
            if (orderPaymentStatus == null)
            {
                return NotFound();
            }

            _context.OrderPaymentStatuses.Remove(orderPaymentStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderPaymentStatusExists(long id)
        {
            return _context.OrderPaymentStatuses.Any(e => e.Id == id);
        }
    }
}

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
    public class OrderTypesController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public OrderTypesController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/OrderTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderType>>> GetOrderTypes()
        {
            return await _context.OrderTypes.ToListAsync();
        }

        // GET: api/OrderTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderType>> GetOrderType(long id)
        {
            var orderType = await _context.OrderTypes.FindAsync(id);

            if (orderType == null)
            {
                return NotFound();
            }

            return orderType;
        }

        // PUT: api/OrderTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderType(long id, OrderType orderType)
        {
            if (id != orderType.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderTypeExists(id))
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

        // POST: api/OrderTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderType>> PostOrderType(OrderType orderType)
        {
            _context.OrderTypes.Add(orderType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderType", new { id = orderType.Id }, orderType);
        }

        // DELETE: api/OrderTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderType(long id)
        {
            var orderType = await _context.OrderTypes.FindAsync(id);
            if (orderType == null)
            {
                return NotFound();
            }

            _context.OrderTypes.Remove(orderType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderTypeExists(long id)
        {
            return _context.OrderTypes.Any(e => e.Id == id);
        }
    }
}

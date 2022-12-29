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
    public class FavouritePostsController : ControllerBase
    {
        private readonly CRMDevContext _context;

        public FavouritePostsController(CRMDevContext context)
        {
            _context = context;
        }

        // GET: api/FavouritePosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavouritePost>>> GetFavouritePosts()
        {
            return await _context.FavouritePosts.ToListAsync();
        }

        // GET: api/FavouritePosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FavouritePost>> GetFavouritePost(long id)
        {
            var favouritePost = await _context.FavouritePosts.FindAsync(id);

            if (favouritePost == null)
            {
                return NotFound();
            }

            return favouritePost;
        }

        // PUT: api/FavouritePosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavouritePost(long id, FavouritePost favouritePost)
        {
            if (id != favouritePost.Id)
            {
                return BadRequest();
            }

            _context.Entry(favouritePost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavouritePostExists(id))
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

        // POST: api/FavouritePosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FavouritePost>> PostFavouritePost(FavouritePost favouritePost)
        {
            _context.FavouritePosts.Add(favouritePost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavouritePost", new { id = favouritePost.Id }, favouritePost);
        }

        // DELETE: api/FavouritePosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavouritePost(long id)
        {
            var favouritePost = await _context.FavouritePosts.FindAsync(id);
            if (favouritePost == null)
            {
                return NotFound();
            }

            _context.FavouritePosts.Remove(favouritePost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FavouritePostExists(long id)
        {
            return _context.FavouritePosts.Any(e => e.Id == id);
        }
    }
}


using API_Lucky_Draw.Model;
using API_LuckyDraw.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lucky_Draw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly LuckyDrawDbContext _context;

        public UserController(LuckyDrawDbContext context) => _context = context;
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<USER>> Get() => await _context.USER.ToListAsync();

      

        // GET api/<GiftController>/5
        
        //[HttpGet("search/{title}")]
        //[ProducesResponseType(typeof(USER), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> GetByTitle(string title)
        //{
        //    var gift = await _context.USER.SingleOrDefaultAsync(c => c.NAME == name);
        //    return gift == null ? NotFound() : Ok(gift);
        //}
        // POST api/<GiftController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public void Post(USER gift)
        {
            _context.USER.Add(gift);
            _context.SaveChangesAsync();

        }

        // PUT api/<GiftController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Put(USER gift)
        {
            _context.Entry(gift).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        //DELETE api/<GiftController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Delete(int id)
        {
            var issueToDelete = _context.USER.Find(id);
            _context.USER.Remove(issueToDelete);
            _context.SaveChanges();
        }
    }
}

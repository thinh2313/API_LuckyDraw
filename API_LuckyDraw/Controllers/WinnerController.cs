using API_Lucky_Draw.Model;
using API_LuckyDraw.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lucky_Draw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WinnerController : ControllerBase
    {
        private readonly LuckyDrawDbContext _context;

        public WinnerController(LuckyDrawDbContext context) => _context = context;
        // GET: api/<CampaignController>
        [HttpGet]
        public async Task<IEnumerable<WINNER>> Get() => await _context.WINNER.ToListAsync();
        //[HttpGet("search/{title}")]
        //[ProducesResponseType(typeof(WINNER), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> GetByTitle(string title)
        //{
        //    var winner = await _context.WINNER.SingleOrDefaultAsync(c => c.NAME == name);
        //    return winner == null ? NotFound() : Ok(winner);
        //}
        // POST api/<GiftController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public void Post(WINNER winner)
        {
            _context.WINNER.Add(winner);
            _context.SaveChangesAsync();

        }
        //DELETE api/<GiftController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Delete(int id)
        {
            var issueToDelete = _context.WINNER.Find(id);
            _context.WINNER.Remove(issueToDelete);
            _context.SaveChanges();
        }
    }
}

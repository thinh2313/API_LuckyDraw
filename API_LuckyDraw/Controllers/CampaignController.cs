
using API_Lucky_Draw.Model;
using API_LuckyDraw.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Lucky_Draw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly LuckyDrawDbContext _context;

        public CampaignController(LuckyDrawDbContext context) => _context = context;
        // GET: api/<CampaignController>
        [HttpGet]
        public IEnumerable<CAMPAIGN> Get() => _context.CAMPAIGN.ToList();
        // GET: api/<GiftController>
        // GET api/<GiftController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CAMPAIGN), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public object GetById(string id)
        {
            var gift = _context.CAMPAIGN.Find(id);
            return gift == null ? NotFound() : Ok(gift);
        }
        //[HttpGet("search/{title}")]
        //[ProducesResponseType(typeof(GIFT), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> GetByTitle(string title)
        //{
        //    var gift = await _context.GIFT.SingleOrDefaultAsync(c => c.NAME == name);
        //    return gift == null ? NotFound() : Ok(gift);
        //}
        // POST api/<GiftController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public void Post(CAMPAIGN gift)
        {
            _context.CAMPAIGN.Add(gift);
            _context.SaveChangesAsync();

        }

        // PUT api/<GiftController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Put(CAMPAIGN gift)
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
            var issueToDelete = _context.CAMPAIGN.Find(id);
            _context.CAMPAIGN.Remove(issueToDelete);
            _context.SaveChanges();
        }
    }
}

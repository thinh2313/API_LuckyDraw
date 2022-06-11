
using API_Lucky_Draw.Model;
using API_LuckyDraw.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Lucky_Draw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailCampaignController : ControllerBase
    {
        private readonly LuckyDrawDbContext _context;

        public DetailCampaignController(LuckyDrawDbContext context) => _context = context;
        // GET: api/<CampaignController>
        [HttpGet]
        public async Task<IEnumerable<CAMPAIGN_DETAIL>> Get() => await _context.CAMPAIGN_DETAIL.ToListAsync();

        // GET api/<CampaignController>/5
    
        // POST api/<GiftController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public void Post(CAMPAIGN_DETAIL de_campaign)
        {
            _context.CAMPAIGN_DETAIL.Add(de_campaign);
            _context.SaveChangesAsync();

        }

        // PUT api/<GiftController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Put(CAMPAIGN_DETAIL de_campaign)
        {
            _context.Entry(de_campaign).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        //DELETE api/<GiftController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Delete(string code)
        {
            var issueToDelete = _context.CAMPAIGN_DETAIL.Find(code);
            _context.CAMPAIGN_DETAIL.Remove(issueToDelete);
            _context.SaveChanges();
        }
    }
}

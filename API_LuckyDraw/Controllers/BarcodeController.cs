
using API_Lucky_Draw.Model;
using API_LuckyDraw.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_LuckyDraw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeController : ControllerBase
    {
        private readonly LuckyDrawDbContext _context;

        public BarcodeController(LuckyDrawDbContext context) => _context = context;
        // GET: api/<BarcodeController>
        [HttpGet]
        public async Task<IEnumerable<BARCODE>> Get() => await _context.BARCODE.ToListAsync();

        //[HttpGet("search/{title}")]
        //[ProducesResponseType(typeof(BARCODE), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> GetByTitle(string title)
        //{
        //    var gift = await _context.BARCODE.SingleOrDefaultAsync(c => c.NAME == name);
        //    return gift == null ? NotFound() : Ok(gift);
        //}
        // POST api/<GiftController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public void Post(BARCODE gift)
        {
            _context.BARCODE.Add(gift);
            _context.SaveChangesAsync();

        }

        // PUT api/<GiftController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Put(BARCODE gift)
        {
            _context.Entry(gift).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        //DELETE api/<GiftController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Delete(string id)
        {
            var issueToDelete = _context.BARCODE.Find(id);
            _context.BARCODE.Remove(issueToDelete);
            _context.SaveChanges();
        }
    }
}

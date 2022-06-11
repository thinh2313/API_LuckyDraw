
using API_Lucky_Draw.Model;
using API_LuckyDraw.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_LuckyDraw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftController : ControllerBase
    {
        private readonly LuckyDrawDbContext _context;
        public GiftController(LuckyDrawDbContext context)
        {
            _context = context;
        }

        // GET: api/<GiftController>
        [HttpGet]
        public IEnumerable<GIFT> Get()
        {
            return _context.GIFT.ToList();
        }

        // GET api/<GiftController>/5
        [HttpGet("{id}")]
        public object GetByCode(string id)
        {
            var gift = _context.GIFT.Find(id);
            return gift;
        }

        // POST api/<GiftController>
        [HttpPost]
        public void Post(GIFT gift)
        {
            _context.GIFT.Add(gift);
            _context.SaveChanges();
        }

        // PUT api/<GiftController>/5
        [HttpPut("{id}")]
        public void Put( GIFT gift)
        {
            _context.Entry(gift).State=EntityState.Modified;
            _context.SaveChanges();
        }

        // DELETE api/<GiftController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
          var idDelete = _context.GIFT.Find(id);
            _context.GIFT.Remove(idDelete);
            _context.SaveChanges();
        }
    }
}

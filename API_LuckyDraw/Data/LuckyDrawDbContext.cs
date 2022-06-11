using API_Lucky_Draw.Model;
using Microsoft.EntityFrameworkCore;

namespace API_LuckyDraw.Data
{
    public class LuckyDrawDbContext:DbContext
    {
        public LuckyDrawDbContext(DbContextOptions<LuckyDrawDbContext> options)
          : base(options)
        {
        }

        public DbSet<CAMPAIGN> CAMPAIGN { get; set; }
        public DbSet<GIFT> GIFT { get; set; }
        public DbSet<USER> USER { get; set; }
        public DbSet<WINNER> WINNER { get; set; }
        public DbSet<BARCODE> BARCODE { get; set; }
        public DbSet<CAMPAIGN_DETAIL> CAMPAIGN_DETAIL { get; set; }

    }
}

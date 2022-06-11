using System.ComponentModel.DataAnnotations;

namespace API_Lucky_Draw.Model
{
    public class CAMPAIGN
    {
        public CAMPAIGN()
        {
            this.BARCODEs = new HashSet<BARCODE>();
            this.CAMPAIGN_DETAIL = new HashSet<CAMPAIGN_DETAIL>();
            this.WINNERs = new HashSet<WINNER>();
        }
        [Key]
        public int IDCAMPAIGN { get; set; }
        [Required]
        public string NAME { get; set; }
        [Required]
        public DateTime? STARTDATE { get; set; }
        public DateTime? EXPIREDDATE { get; set; }
        public int? ACTIVECODE { get; set; }
        public int? QUANTITYGIFT { get; set; }
        public string DESCRIPTION { get; set; }
        public int? SCAN { get; set; }
        public int? WIN { get; set; }

        public virtual ICollection<BARCODE> BARCODEs { get; set; }
        public virtual ICollection<CAMPAIGN_DETAIL> CAMPAIGN_DETAIL { get; set; }
        public virtual ICollection<WINNER> WINNERs { get; set; }

        public string StartDay { get; set; }
        public string EndDay { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

    }
}

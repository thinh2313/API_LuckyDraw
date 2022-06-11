using System.ComponentModel.DataAnnotations;

namespace API_Lucky_Draw.Model
{
    public class GIFT
    {
        public GIFT()
        {
            this.CAMPAIGN_DETAIL = new HashSet<CAMPAIGN_DETAIL>();
            this.WINNERs = new HashSet<WINNER>();
        }
        [Key]
        public string CODE { get; set; }
        [Required]
        public string NAME { get; set; }
        [Required]
        public string DESCRIPTION { get; set; }
        public bool? ACTIVE { get; set; }
        public DateTime? CREATEDATE { get; set; }
        public int? CODEUSAGELIMIT { get; set; }

        public virtual ICollection<CAMPAIGN_DETAIL> CAMPAIGN_DETAIL { get; set; }
        public virtual ICollection<WINNER> WINNERs { get; set; }
       
    }
}

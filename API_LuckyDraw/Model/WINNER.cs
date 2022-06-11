using System.ComponentModel.DataAnnotations;

namespace API_Lucky_Draw.Model
{
    public class WINNER
    {
        public int IDWINNER { get; set; }
        [Required]
        public int IDCAMPAIGN { get; set; }
        [Required]
        public int ID { get; set; }
        [Required]
        public string CODE { get; set; }
        public DateTime?     WINDATE { get; set; }

        public virtual CAMPAIGN CAMPAIGN { get; set; }
        public virtual GIFT GIFT { get; set; }
        public virtual USER USER { get; set; }
    }
}

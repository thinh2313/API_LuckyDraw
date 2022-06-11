using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace API_Lucky_Draw.Model
{
    public class CAMPAIGN_DETAIL
    {
        [Key]
        public int ID_DE_CAMPAIGN { get; set; }

        public int IDCAMPAIGN { get; set; }
        public string CODE { get; set; }
        public bool? ACTIVE { get; set; }
        public int? WIN { get; set; }
        public DateTime? WINDATE { get; set; }

        public virtual CAMPAIGN CAMPAIGN { get; set; }
        public virtual GIFT GIFT { get; set; }
        
    }
  
}

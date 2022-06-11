using System.ComponentModel.DataAnnotations;

namespace API_Lucky_Draw.Model
{
    public class BARCODE
    {
        [Key]
        public string CODE { get; set; }
        [Required]
        public int IDCAMPAIGN { get; set; }
        [Required]
        public string CODEBAR { get; set; }
        [Required]
        public string QRCODE { get; set; }
        [Required]
        public DateTime? CREATEDATE { get; set; }
        public DateTime? EXPIREDDATE { get; set; }
        public DateTime? SCANNEDDATE { get; set; }

        public virtual CAMPAIGN CAMPAIGN { get; set; }
    }
}

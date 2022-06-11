using System.ComponentModel.DataAnnotations;

namespace API_Lucky_Draw.Model
{
    public class USER
    {
        public USER()
        {
            this.WINNERs = new HashSet<WINNER>();
        }
        [Key]
        public int ID { get; set; }
        [Required]
        public string NAME { get; set; }
        [Required]
        public DateTime? DATEOFBIRTH { get; set; }
        public string LOCATION { get; set; }
        public int PHONE { get; set; }
        [Required]
        public string POSITION { get; set; }
        public string TYPEOFBUSINESS { get; set; }
        public string PASSWORD { get; set; }

        public virtual ICollection<WINNER> WINNERs { get; set; }
    }
}

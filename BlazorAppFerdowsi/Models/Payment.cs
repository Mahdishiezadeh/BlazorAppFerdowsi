using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppFerdowsi.Models
{
    public class Payment
    {
        [Key]
        public long Id { get; set; }
        public bool IsPay { get; set; } = false;
        public DateTime PaymentDate { get; set; }= DateTime.Now;


        public ICollection<Box> Boxes { get; set; }
        [ForeignKey("Box")]
        public long BoxId { get; set; }



    }
}

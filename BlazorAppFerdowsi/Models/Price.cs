using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppFerdowsi.Models
{
    public class Price
    {
        [Key]
        public long Id  { get; set; }
        public DateTime SetPriceDate { get; set; }= DateTime.Now;
        public long BoxPrice { get; set; }


        [ForeignKey("Box")]
        public long BoxId { get; set; }
        public ICollection<Box> Boxes { get; set; }
    }
}

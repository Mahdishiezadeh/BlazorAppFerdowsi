using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppFerdowsi.Models
{
    public class Status
    {
        [Key]
        public long Id { get; set; }
        public int key { get; set; }
        public string Value { get; set; }

       
        public ICollection<User> Users { get; set; }
        [ForeignKey("User")]
        public long UserId { get; set; }

        public ICollection<Box> Boxes { get; set; }
        [ForeignKey("Box")]
        public long BoxId { get; set; }

    }
}

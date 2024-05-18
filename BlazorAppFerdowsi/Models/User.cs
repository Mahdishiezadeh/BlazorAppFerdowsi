using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppFerdowsi.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Bio { get; set; }
      

        public ICollection<Box> Boxes { get; set; }

        [ForeignKey("Box")]
        public long BoxId { get; set; }

        public ICollection<Status> Statuses { get; set; }

        [ForeignKey("Status")]
        public long StatusId { get; set; }


    }
}

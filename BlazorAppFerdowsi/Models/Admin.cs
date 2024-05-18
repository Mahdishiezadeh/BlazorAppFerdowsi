using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppFerdowsi.Models
{
    public class Admin
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }

        public ICollection<Box> Boxes { get; set; }
        [ForeignKey("Box")]
        public long BoxId { get; set; }

    }
}

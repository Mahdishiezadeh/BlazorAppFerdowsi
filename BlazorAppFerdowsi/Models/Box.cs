using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppFerdowsi.Models
{
    public class Box
    {
        public long Id { get; set; }
        public string Tiltle { get; set; }
        public string Bio { get; set; }

        public ICollection<Price> Prices { get; set; }
        [ForeignKey("Price")]
        public long PriceId { get; set;}

        public ICollection<Status> Statuses { get; set; }

        [ForeignKey("Status")]
        public long StatusId { get; set; }

        public ICollection<User> Users { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public ICollection<Payment> Payments { get; set; }

        [ForeignKey("Payment")]
        public long PaymentId { get; set; }


        public ICollection<Admin> Admins { get; set; }

        [ForeignKey("Admin")]
        public long AdminId { get; set; }



    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LogRegTest.Models
{
    public class UserTickets
    {
        [Key]
        public int UserId { get; set; }

        [Key]
        public int TicketId { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}

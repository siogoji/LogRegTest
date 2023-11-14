using LogRegTest.Migrations;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace LogRegTest.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string Type { get; set; }
        public string Period { get; set; }
        public int Price { get; set; }

        // Додайте властивість для зв'язку багато до багатьох
        public ICollection<UserTicket>? UserTickets { get; set; }
    }

}

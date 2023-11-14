using LogRegTest.Migrations;
using Microsoft.AspNetCore.Identity;

namespace LogRegTest.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        // Додайте властивість для зв'язку багато до багатьох
        public ICollection<UserTicket> UserTickets { get; set; }
    }
}

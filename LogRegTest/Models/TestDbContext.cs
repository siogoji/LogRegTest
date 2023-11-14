using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LogRegTest.ViewModels;

namespace LogRegTest.Models
{
    public class TestDbContext : IdentityDbContext<ApplicationUser>
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<UserTicket> UserTickets { get; set; }
    }
}

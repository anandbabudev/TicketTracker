using Microsoft.EntityFrameworkCore;

namespace TicketTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Ticket> Tickets => Set<Ticket>();
    }
}

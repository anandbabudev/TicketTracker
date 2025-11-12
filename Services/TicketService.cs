using Microsoft.EntityFrameworkCore;
using TicketTracker.Data;

namespace TicketTracker.Services
{
    public class TicketService
    {
        private readonly ApplicationDbContext _context;

        public TicketService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ticket>> GetAllAsync() =>
            await _context.Tickets.OrderByDescending(t => t.CreatedAt).ToListAsync();

        public async Task AddAsync(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var t = await _context.Tickets.FindAsync(id);
            if (t != null)
            {
                _context.Tickets.Remove(t);
                await _context.SaveChangesAsync();
            }
        }
    }
}

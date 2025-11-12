namespace TicketTracker.Data
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Open"; // Open, In Progress, Resolved, Closed
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

using System.ComponentModel.DataAnnotations;

namespace Tessera.Ticket.API.Model
{
    public class TicketModel
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Details { get; set; }
        [Required]
        public DateTime? CreatedDate { get; set; }
        [Required]
        public DateTime? DueDate { get; set; }
        [Required]
        public Urgency? Urgency { get; set; }
        [Required]
        public WorkStatus? WorkStatus { get; set; }
        [Required]
        public int? CreatedBy { get; set; }
        [Required]
        public int? AppointedTo { get; set; }
        [Required]
        public int? AppeallId { get; set; }
    }
    public enum Urgency
    {
        Low,
        Medium,
        High
    }
    public enum WorkStatus
    {
        Completed,
        Cancelled,
        Progress
    }
}

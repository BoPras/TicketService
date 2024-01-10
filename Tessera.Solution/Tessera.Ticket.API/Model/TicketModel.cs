using System.ComponentModel.DataAnnotations;

namespace Tessera.Ticket.API.Model
{
    public class TicketModel
    {
        [Required]
        public string? Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Details { get; set; }
        [Required]
        public DateTime? CreatedDate { get; set; }
        [Required]
        public DateTime? DueDate { get; set; }
        [Required]
        public string? Urgency { get; set; }
        [Required]
        public string? WorkStatus { get; set; }
        [Required]
        public int? CreatedBy { get; set; }
        [Required]
        public int? AppointedTo { get; set; }
        [Required]
        public int? AppealId { get; set; }
    }
}

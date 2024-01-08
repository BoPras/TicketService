using System.ComponentModel.DataAnnotations;

namespace Tessera.TicketSolution.API.Model
{
    public class TicketSolutionModel
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string? Details { get; set; }
        [Required]
        public DateTime? CompletedDate { get; set; }
        [Required]
        public int? MyProperty { get; set; }
        [Required]
        public CompletedStatus? CompletedStatus { get; set; }

        public DateTime? SupervisorReviewDate { get; set; }
        [Required]
        public int? Supervisor { get; set; }
    }
    public enum CompletedStatus
    {
        OnTime,
        OnLate,
        Cancelled
    }
}

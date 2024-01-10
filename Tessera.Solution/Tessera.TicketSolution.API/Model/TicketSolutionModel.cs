using System.ComponentModel.DataAnnotations;

namespace Tessera.TicketSolution.API.Model
{
    public class TicketSolutionModel
    {
        [Required]
        public string? Id { get; set; }
        [Required]
        public string? Details { get; set; }
        [Required]
        public DateTime? CompletedDate { get; set; }
        [Required]
        public string? CompletionStatus { get; set; }
        public DateTime? SupervisorReviewDate { get; set; }
        [Required]
        public int? Supervisor { get; set; }
    }
}

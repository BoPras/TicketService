using System.ComponentModel.DataAnnotations;

namespace Tessera.Apeeal.API.Model
{
    public class AppealModel
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}

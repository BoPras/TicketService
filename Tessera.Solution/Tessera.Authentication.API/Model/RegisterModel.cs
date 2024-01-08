using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tessera.Authentication.API.Model
{
    public class RegisterModel
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        [PasswordPropertyText]
        public string? Password { get; set; }
        [Required]
        public string? Role { get; set; }
    }
}

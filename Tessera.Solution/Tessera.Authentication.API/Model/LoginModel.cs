using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tessera.Authentication.API.Model
{
    public class LoginModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        [PasswordPropertyText]
        public string? Password { get; set; }
    }
}

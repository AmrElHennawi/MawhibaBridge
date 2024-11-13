using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Application.DTOs
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool RememberMe { get; set; } = false;
    }
}

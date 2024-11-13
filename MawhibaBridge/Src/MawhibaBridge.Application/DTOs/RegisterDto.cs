using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Application.DTOs
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        public int? Age { get; set; }

        [MaxLength(255)]
        public string? Degree { get; set; }

        [Url]
        public string? LinkedIdUrl { get; set; }

        [Required]
        public bool Visability { get; set; } = false;
    }
}

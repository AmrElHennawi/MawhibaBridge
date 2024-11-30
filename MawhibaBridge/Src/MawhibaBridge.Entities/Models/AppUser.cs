using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Entities.Models
{
    public class AppUser:IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Range(typeof(int),"0","100")]
        public int? Age { get; set; }

        [MaxLength(255)]
        public string? Degree { get; set; }

        [Url]
        public string? LinkedIdUrl { get; set; }

        public string? Image {  get; set; }

        public string? Resume { get; set; }

        [Required]
        public bool Visability { get;set; } = false;

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        public bool IsDeleted { get; set; } = false;

        public ICollection<Instructor> Instructors { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Reply> Replies { get; set; }

        public ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}

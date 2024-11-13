using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Entities.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CourseName { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string Content { get; set; }

        public string? Courseimage {  get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}

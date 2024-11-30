

using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Entities.Models
{
    public class Instructor
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public string InstructorId { get; set; }
        public Course Course { get; set; }
        public AppUser CourseInstructor { get; set; }
    }
}

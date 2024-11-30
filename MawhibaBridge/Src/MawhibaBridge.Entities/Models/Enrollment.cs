

using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Entities.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public string StudentId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;

        public Course Course { get; set; }

        public AppUser Student { get; set; }

        public ICollection<SectionSeen> SeenSections { get; set; }
    }
}

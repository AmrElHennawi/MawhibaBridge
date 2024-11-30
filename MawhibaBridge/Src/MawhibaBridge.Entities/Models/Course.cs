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
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        public string? CourseCover {  get; set; }

        [Required]
        public decimal TotalCourseHours { get; set; }

        [Required]
        public int CourseTypeId { get; set;}

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public CourseType CourseType { get; set; }

        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Section> Sections { get; set; }

    }
}

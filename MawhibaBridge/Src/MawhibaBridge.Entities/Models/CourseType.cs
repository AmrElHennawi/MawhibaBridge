

using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Entities.Models
{
    public class CourseType
    {
        [Key]
        public int CourseTypeId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Type { get; set; }
        public Course Course { get; set; }
    }
}

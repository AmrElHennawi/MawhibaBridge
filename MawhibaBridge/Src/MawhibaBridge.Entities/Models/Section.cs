
using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Entities.Models
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(50)]
        public string SectionTitle { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        public string ContentFile {  get; set; }

        public string? AttachedFile {  get; set; }

        public Course Course { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<SectionSeen> SeenByStudents { get; set; }
    }
}

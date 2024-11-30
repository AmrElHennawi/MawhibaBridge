

using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Entities.Models
{
    public class SectionSeen
    {

        [Key]
        public int SectionSeenId { get; set; }

        [Required]
        public int EnrollmentId { get; set; }

        [Required]
        public int SectionId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateSeen { get; set; } = DateTime.UtcNow;

        public Section Section { get; set; }

        public Enrollment Enrollment { get; set; }

    }
}

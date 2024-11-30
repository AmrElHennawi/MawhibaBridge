

using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Entities.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public int SectionId { get; set; }

        [Required]
        public string StudentId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PostedAt { get; set; } = DateTime.UtcNow;

        public Section Section { get; set; }

        public AppUser User { get; set; }

        public ICollection<Reply> Replies { get; set; }
    }
}

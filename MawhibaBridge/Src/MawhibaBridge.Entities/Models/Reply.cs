

using System.ComponentModel.DataAnnotations;

namespace MawhibaBridge.Entities.Models
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }

        [Required]
        public int CommentId { get; set; }

        [Required]
        public string StudentId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PostedAt { get; set; } = DateTime.UtcNow;
        public Comment Comment { get; set; }

        public AppUser User { get; set; }

    }
}

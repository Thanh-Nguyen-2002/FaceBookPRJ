using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class Mention
    {
        public int Id { get; set; }
        public int MentionedUserId { get; set; }
        public int? PostId { get; set; }
        public int? CommentId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Comment? Comment { get; set; }
        public virtual User MentionedUser { get; set; } = null!;
        public virtual Post? Post { get; set; }
    }
}

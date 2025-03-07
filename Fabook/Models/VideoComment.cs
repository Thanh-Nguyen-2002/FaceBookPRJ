using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class VideoComment
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Video Video { get; set; } = null!;
    }
}

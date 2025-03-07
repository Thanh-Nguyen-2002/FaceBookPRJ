using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class VideoReaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VideoId { get; set; }
        public string Type { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Video Video { get; set; } = null!;
    }
}

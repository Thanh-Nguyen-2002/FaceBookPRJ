using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class VideoView
    {
        public int UserId { get; set; }
        public int VideoId { get; set; }
        public DateTime? ViewedAt { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Video Video { get; set; } = null!;
    }
}

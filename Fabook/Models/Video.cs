using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class Video
    {
        public Video()
        {
            VideoComments = new HashSet<VideoComment>();
            VideoReactions = new HashSet<VideoReaction>();
            VideoViews = new HashSet<VideoView>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string VideoUrl { get; set; } = null!;
        public string? ThumbnailUrl { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? Visibility { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<VideoComment> VideoComments { get; set; }
        public virtual ICollection<VideoReaction> VideoReactions { get; set; }
        public virtual ICollection<VideoView> VideoViews { get; set; }
    }
}

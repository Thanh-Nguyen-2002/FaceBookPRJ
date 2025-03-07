using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            Mentions = new HashSet<Mention>();
            Reactions = new HashSet<Reaction>();
            Reports = new HashSet<Report>();
            SavedPosts = new HashSet<SavedPost>();
            Shares = new HashSet<Share>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; } = null!;
        public string? Image { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? Visibility { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Mention> Mentions { get; set; }
        public virtual ICollection<Reaction> Reactions { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<SavedPost> SavedPosts { get; set; }
        public virtual ICollection<Share> Shares { get; set; }
    }
}

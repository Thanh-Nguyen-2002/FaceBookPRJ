using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class Comment
    {
        public Comment()
        {
            Mentions = new HashSet<Mention>();
            Reports = new HashSet<Report>();
        }

        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public virtual Post Post { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Mention> Mentions { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class GroupPost
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; } = null!;
        public string? Image { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Group Group { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

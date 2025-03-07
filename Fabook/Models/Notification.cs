using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; } = null!;
        public int RelatedId { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? Details { get; set; }

        public virtual User User { get; set; } = null!;
    }
}

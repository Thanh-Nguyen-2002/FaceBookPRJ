using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class BlockedUser
    {
        public int BlockerId { get; set; }
        public int BlockedId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User Blocked { get; set; } = null!;
        public virtual User Blocker { get; set; } = null!;
    }
}

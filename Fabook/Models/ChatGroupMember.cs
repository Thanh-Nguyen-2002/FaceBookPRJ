using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class ChatGroupMember
    {
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public DateTime? JoinedAt { get; set; }

        public virtual ChatGroup Group { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

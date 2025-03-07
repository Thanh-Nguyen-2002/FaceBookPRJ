using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class ChatGroup
    {
        public ChatGroup()
        {
            ChatGroupMembers = new HashSet<ChatGroupMember>();
            ChatGroupMessages = new HashSet<ChatGroupMessage>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<ChatGroupMember> ChatGroupMembers { get; set; }
        public virtual ICollection<ChatGroupMessage> ChatGroupMessages { get; set; }
    }
}

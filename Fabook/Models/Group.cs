using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class Group
    {
        public Group()
        {
            GroupMembers = new HashSet<GroupMember>();
            GroupPosts = new HashSet<GroupPost>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<GroupMember> GroupMembers { get; set; }
        public virtual ICollection<GroupPost> GroupPosts { get; set; }
    }
}

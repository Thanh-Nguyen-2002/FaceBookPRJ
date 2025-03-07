﻿using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class GroupMember
    {
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public string? Role { get; set; }
        public DateTime? JoinedAt { get; set; }

        public virtual Group Group { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

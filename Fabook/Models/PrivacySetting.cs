using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class PrivacySetting
    {
        public int UserId { get; set; }
        public bool? AllowFriendRequests { get; set; }
        public bool? AllowMessages { get; set; }
        public string? ProfileVisibility { get; set; }

        public virtual User User { get; set; } = null!;
    }
}

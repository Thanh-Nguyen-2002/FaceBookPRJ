using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class ChatGroupMessage
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int SenderId { get; set; }
        public string Content { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public virtual ChatGroup Group { get; set; } = null!;
        public virtual User Sender { get; set; } = null!;
    }
}

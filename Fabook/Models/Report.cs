using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class Report
    {
        public int Id { get; set; }
        public int ReporterId { get; set; }
        public int ReportedId { get; set; }
        public int? PostId { get; set; }
        public int? CommentId { get; set; }
        public string Reason { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public virtual Comment? Comment { get; set; }
        public virtual Post? Post { get; set; }
        public virtual User Reported { get; set; } = null!;
        public virtual User Reporter { get; set; } = null!;
    }
}

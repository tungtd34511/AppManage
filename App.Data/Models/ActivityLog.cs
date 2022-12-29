using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class ActivityLog
    {
        public long Id { get; set; }
        public bool Active { get; set; }
        public long AccountId { get; set; }
        public string Name { get; set; } = null!;
        public string EntityCode { get; set; } = null!;
        public string? Info { get; set; }
        public string? ObjectOld { get; set; }
        public string? ObjectNew { get; set; }
        public string? Url { get; set; }
        public string? UrlSource { get; set; }
        public string? IpAddress { get; set; }
        public string? Device { get; set; }
        public string? Browser { get; set; }
        public string? Os { get; set; }
        public string? UserAgent { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}

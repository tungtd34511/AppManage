using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Password
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public bool Active { get; set; }
        public string OldPassword { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}

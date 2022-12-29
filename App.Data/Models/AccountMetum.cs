using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class AccountMetum
    {
        public long Id { get; set; }
        public bool Active { get; set; }
        public long AccountId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public DateTime CreatedTime { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class AccountStatus
    {
        public AccountStatus()
        {
            Accounts = new HashSet<Account>();
        }

        public long Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}

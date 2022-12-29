using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            RolePermissions = new HashSet<RolePermission>();
            Accounts = new HashSet<Account>();
        }

        public long Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}

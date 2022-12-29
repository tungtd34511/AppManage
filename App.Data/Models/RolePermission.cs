using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class RolePermission
    {
        public long RoleId { get; set; }
        public string PermissionCode { get; set; } = null!;

        public virtual Role Role { get; set; } = null!;
    }
}

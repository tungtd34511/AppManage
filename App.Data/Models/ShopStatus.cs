using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class ShopStatus
    {
        public ShopStatus()
        {
            Shops = new HashSet<Shop>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Shop> Shops { get; set; }
    }
}

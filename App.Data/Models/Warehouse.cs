using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            WarehouseProducts = new HashSet<WarehouseProduct>();
            Shops = new HashSet<Shop>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; }

        public virtual ICollection<Shop> Shops { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class ProductSize
    {
        public ProductSize()
        {
            WarehouseProducts = new HashSet<WarehouseProduct>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; }
    }
}

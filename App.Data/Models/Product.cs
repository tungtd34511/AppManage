using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            ShopProducts = new HashSet<ShopProduct>();
            WarehouseProducts = new HashSet<WarehouseProduct>();
        }

        public long Id { get; set; }
        public long ProductCategoryId { get; set; }
        public long ProductBrandId { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Photo { get; set; } = null!;
        public long ProductUnitId { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ProductBrand ProductBrand { get; set; } = null!;
        public virtual ProductCategory ProductCategory { get; set; } = null!;
        public virtual ProductUnit ProductUnit { get; set; } = null!;
        public virtual ICollection<ShopProduct> ShopProducts { get; set; }
        public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; }
    }
}

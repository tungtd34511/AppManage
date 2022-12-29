using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            InverseParent = new HashSet<ProductCategory>();
            Products = new HashSet<Product>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ProductCategory? Parent { get; set; }
        public virtual ICollection<ProductCategory> InverseParent { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

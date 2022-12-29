using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class ProductVariantGroup
    {
        public ProductVariantGroup()
        {
            ProductVariants = new HashSet<ProductVariant>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
    }
}

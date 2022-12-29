using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class ProductVariant
    {
        public long Id { get; set; }
        public long ProductVariantGroupId { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ProductVariantGroup ProductVariantGroup { get; set; } = null!;
    }
}

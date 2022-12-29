using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class ProductUnit
    {
        public ProductUnit()
        {
            Products = new HashSet<Product>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

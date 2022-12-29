using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class WarehouseProduct
    {
        public WarehouseProduct()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long Id { get; set; }
        public long WareHouseId { get; set; }
        public long ProductId { get; set; }
        public string ProductVarientIds { get; set; } = null!;
        public long Quantity { get; set; }
        public long? ProductSizeId { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual ProductSize? ProductSize { get; set; }
        public virtual Warehouse WareHouse { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            OrderDetailMeta = new HashSet<OrderDetailMetum>();
        }

        public long Id { get; set; }
        public long OrderId { get; set; }
        public long WarehouseProductId { get; set; }
        public long OrderStatusId { get; set; }
        public int Quantity { get; set; }
        public int QuantityReturn { get; set; }
        public int SoldQuantity { get; set; }
        public int Price { get; set; }
        public int TotalPaid { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int FinalPrice { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual OrderStatus OrderStatus { get; set; } = null!;
        public virtual WarehouseProduct WarehouseProduct { get; set; } = null!;
        public virtual ICollection<OrderDetailMetum> OrderDetailMeta { get; set; }
    }
}

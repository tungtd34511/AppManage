using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string StatusName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

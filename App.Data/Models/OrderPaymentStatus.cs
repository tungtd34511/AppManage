using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class OrderPaymentStatus
    {
        public OrderPaymentStatus()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

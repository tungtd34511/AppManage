using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class OrderType
    {
        public OrderType()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

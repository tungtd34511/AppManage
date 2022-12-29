using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            OrderMeta = new HashSet<OrderMetum>();
            Transactions = new HashSet<Transaction>();
            Promotions = new HashSet<Promotion>();
        }

        public long Id { get; set; }
        public long OrderTypeId { get; set; }
        public long CustomerId { get; set; }
        public long ShopId { get; set; }
        public double DirectDiscount { get; set; }
        public string? Description { get; set; }
        public long OrderStatusId { get; set; }
        public long OrderPaymentStatusId { get; set; }
        public int Price { get; set; }
        public int TotalPaid { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int FinalPrice { get; set; }
        public string? Feedback { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual OrderPaymentStatus OrderPaymentStatus { get; set; } = null!;
        public virtual OrderStatus OrderStatus { get; set; } = null!;
        public virtual OrderType OrderType { get; set; } = null!;
        public virtual Shop Shop { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderMetum> OrderMeta { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

        public virtual ICollection<Promotion> Promotions { get; set; }
    }
}

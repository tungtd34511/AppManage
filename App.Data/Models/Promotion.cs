using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Promotion
    {
        public Promotion()
        {
            PromotionMeta = new HashSet<PromotionMetum>();
            Vouchers = new HashSet<Voucher>();
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Code { get; set; } = null!;
        public double Discount { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<PromotionMetum> PromotionMeta { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

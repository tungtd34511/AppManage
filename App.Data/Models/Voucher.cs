using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            VoucherMeta = new HashSet<VoucherMetum>();
        }

        public long Id { get; set; }
        public long PromotionId { get; set; }
        public long VoucherTypeId { get; set; }
        public long VoucherStatusId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Info { get; set; }
        public int Quantity { get; set; }
        public int Value { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Promotion Promotion { get; set; } = null!;
        public virtual VoucherStatus VoucherStatus { get; set; } = null!;
        public virtual VoucherType VoucherType { get; set; } = null!;
        public virtual ICollection<VoucherMetum> VoucherMeta { get; set; }
    }
}

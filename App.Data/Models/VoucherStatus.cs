using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class VoucherStatus
    {
        public VoucherStatus()
        {
            Vouchers = new HashSet<Voucher>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}

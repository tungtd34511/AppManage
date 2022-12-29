using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class VoucherMetum
    {
        public long Id { get; set; }
        public long VoucherId { get; set; }
        public string Name { get; set; } = null!;
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Voucher Voucher { get; set; } = null!;
    }
}

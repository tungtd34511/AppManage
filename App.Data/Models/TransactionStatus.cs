using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class TransactionStatus
    {
        public TransactionStatus()
        {
            Transactions = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

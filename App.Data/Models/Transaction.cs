using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            TransactionMeta = new HashSet<TransactionMetum>();
        }

        public long Id { get; set; }
        public long TransactionTypeId { get; set; }
        public long TransactionStatusId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Info { get; set; }
        public int Amount { get; set; }
        public string? SenderInfo { get; set; }
        public string? ReceiveInfo { get; set; }
        public long OrderId { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual TransactionStatus TransactionStatus { get; set; } = null!;
        public virtual TransactionType TransactionType { get; set; } = null!;
        public virtual ICollection<TransactionMetum> TransactionMeta { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class CustomerCategory
    {
        public CustomerCategory()
        {
            Customers = new HashSet<Customer>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public double Discount { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}

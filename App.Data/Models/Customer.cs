using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public long CustomerCategoryId { get; set; }
        public string Fullname { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? CitizenId { get; set; }
        public string? Description { get; set; }
        public string? Photo { get; set; }
        public string? IdcardNumberPhoto1 { get; set; }
        public string? IdcardNumberPhoto2 { get; set; }
        public DateTime? DoB { get; set; }
        public string? Zipcode { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressDistrict { get; set; }
        public string? AddressWard { get; set; }
        public string? AddressDetail { get; set; }
        public string Search { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual CustomerCategory CustomerCategory { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}

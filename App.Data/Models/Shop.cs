using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Shop
    {
        public Shop()
        {
            Orders = new HashSet<Order>();
            ShopMeta = new HashSet<ShopMetum>();
            ShopProducts = new HashSet<ShopProduct>();
            WareHouses = new HashSet<Warehouse>();
        }

        public long Id { get; set; }
        public long ShopTypeId { get; set; }
        public long ShopStatusId { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Photo { get; set; } = null!;
        public string? Description { get; set; }
        public string? Info { get; set; }
        public string? ContactPerson { get; set; }
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressDistrict { get; set; }
        public string? AddressWard { get; set; }
        public string? AddressDetail { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ShopStatus ShopStatus { get; set; } = null!;
        public virtual ShopType ShopType { get; set; } = null!;
        public virtual Account User { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ShopMetum> ShopMeta { get; set; }
        public virtual ICollection<ShopProduct> ShopProducts { get; set; }

        public virtual ICollection<Warehouse> WareHouses { get; set; }
    }
}

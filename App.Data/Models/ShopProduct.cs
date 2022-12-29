using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class ShopProduct
    {
        public long ShopId { get; set; }
        public long ProductId { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }
        public double RentPrice { get; set; }
        public int? MaximumDayForRent { get; set; }

        public virtual Product Shop { get; set; } = null!;
        public virtual Shop ShopNavigation { get; set; } = null!;
    }
}

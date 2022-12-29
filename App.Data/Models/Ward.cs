using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Ward
    {
        public long Id { get; set; }
        public bool Active { get; set; }
        public long DistrictId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual District District { get; set; } = null!;
    }
}

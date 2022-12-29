using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Province
    {
        public Province()
        {
            Districts = new HashSet<District>();
        }

        public long Id { get; set; }
        public bool Active { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<District> Districts { get; set; }
    }
}

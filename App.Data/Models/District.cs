using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class District
    {
        public District()
        {
            Wards = new HashSet<Ward>();
        }

        public long Id { get; set; }
        public bool Active { get; set; }
        public long ProvinceId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Province Province { get; set; } = null!;
        public virtual ICollection<Ward> Wards { get; set; }
    }
}

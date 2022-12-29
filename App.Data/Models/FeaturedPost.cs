using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class FeaturedPost
    {
        public long Id { get; set; }
        public long PostId { get; set; }
        public long FeaturedPostTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual FeaturedPostType FeaturedPostType { get; set; } = null!;
        public virtual Post Post { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class FeaturedPostType
    {
        public FeaturedPostType()
        {
            FeaturedPosts = new HashSet<FeaturedPost>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<FeaturedPost> FeaturedPosts { get; set; }
    }
}

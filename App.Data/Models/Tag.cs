using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Tag
    {
        public Tag()
        {
            PostTags = new HashSet<PostTag>();
        }

        public long Id { get; set; }
        public int? PostCount { get; set; }
        public string Name { get; set; } = null!;
        public string? Name2 { get; set; }
        public string Slug { get; set; } = null!;
        public string? Slug2 { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}

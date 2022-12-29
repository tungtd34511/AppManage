using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class PostCategory
    {
        public PostCategory()
        {
            InverseParent = new HashSet<PostCategory>();
            Posts = new HashSet<Post>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public int? PostCount { get; set; }
        public string Name { get; set; } = null!;
        public string? Name2 { get; set; }
        public string Slug { get; set; } = null!;
        public string? Slug2 { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }
        public string? Photo { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual PostCategory? Parent { get; set; }
        public virtual ICollection<PostCategory> InverseParent { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}

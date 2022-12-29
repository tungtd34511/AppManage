using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class CommentStatus
    {
        public CommentStatus()
        {
            Comments = new HashSet<Comment>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}

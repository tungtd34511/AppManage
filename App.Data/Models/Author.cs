using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Author
    {
        public Author()
        {
            Posts = new HashSet<Post>();
        }

        public long Id { get; set; }
        public long AccountId { get; set; }
        public string Name { get; set; } = null!;
        public string Info { get; set; } = null!;
        public string? Photo { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual ICollection<Post> Posts { get; set; }
    }
}

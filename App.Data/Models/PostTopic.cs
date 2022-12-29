using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class PostTopic
    {
        public long Id { get; set; }
        public long PostId { get; set; }
        public long TopicId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Post Post { get; set; } = null!;
        public virtual Topic Topic { get; set; } = null!;
    }
}

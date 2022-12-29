using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Topic
    {
        public Topic()
        {
            PostTopics = new HashSet<PostTopic>();
        }

        public long Id { get; set; }
        public int? PostCount { get; set; }
        public string Name { get; set; } = null!;
        public string Name2 { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Slug2 { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Photo { get; set; }
        public string? Description { get; set; }
        public string? Text { get; set; }
        public string? Description2 { get; set; }
        public string? Text2 { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<PostTopic> PostTopics { get; set; }
    }
}

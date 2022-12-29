using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            FavouritePosts = new HashSet<FavouritePost>();
            FeaturedPosts = new HashSet<FeaturedPost>();
            PostMeta = new HashSet<PostMetum>();
            PostTags = new HashSet<PostTag>();
            PostTopics = new HashSet<PostTopic>();
            ReadedPosts = new HashSet<ReadedPost>();
        }

        public long Id { get; set; }
        public bool Active { get; set; }
        public long PostTypeId { get; set; }
        public long PostUserId { get; set; }
        public long PostCategoryId { get; set; }
        public long PostLayoutId { get; set; }
        public long PostPublishStatusId { get; set; }
        public long PostCommentStatusId { get; set; }
        public long AuthorId { get; set; }
        public string? GuId { get; set; }
        public string? Photo { get; set; }
        public string? Video { get; set; }
        public int? ViewCount { get; set; }
        public int? CommentCount { get; set; }
        public int? LikeCount { get; set; }
        public string Url { get; set; } = null!;
        public string? Url2 { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Text { get; set; }
        public string? Name2 { get; set; }
        public string? Description2 { get; set; }
        public string? Text2 { get; set; }
        public DateTime? PublishedTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public long? UserId { get; set; }

        public virtual Author Author { get; set; } = null!;
        public virtual PostCategory PostCategory { get; set; } = null!;
        public virtual PostCommentStatus PostCommentStatus { get; set; } = null!;
        public virtual PostLayout PostLayout { get; set; } = null!;
        public virtual PostPublishStatus PostPublishStatus { get; set; } = null!;
        public virtual PostType PostType { get; set; } = null!;
        public virtual Account? User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<FavouritePost> FavouritePosts { get; set; }
        public virtual ICollection<FeaturedPost> FeaturedPosts { get; set; }
        public virtual ICollection<PostMetum> PostMeta { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
        public virtual ICollection<PostTopic> PostTopics { get; set; }
        public virtual ICollection<ReadedPost> ReadedPosts { get; set; }
    }
}

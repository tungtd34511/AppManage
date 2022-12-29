using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class Account
    {
        public Account()
        {
            AccountMeta = new HashSet<AccountMetum>();
            ActivityLogs = new HashSet<ActivityLog>();
            FavouritePosts = new HashSet<FavouritePost>();
            Passwords = new HashSet<Password>();
            Posts = new HashSet<Post>();
            ReadedPosts = new HashSet<ReadedPost>();
            Shops = new HashSet<Shop>();
            Roles = new HashSet<Role>();
        }

        public long Id { get; set; }
        public long? AccountTypeId { get; set; }
        public long? AccountStatusId { get; set; }
        public bool? IsActivated { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string Fullname { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Photo { get; set; }
        public string? Description { get; set; }
        public string? Info { get; set; }
        public string? IdCardNumber { get; set; }
        public string? CompanyNumber { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyInfo { get; set; }
        public string? GoogleId { get; set; }
        public string? FacebookId { get; set; }
        public string? IdcardNumberPhoto1 { get; set; }
        public string? IdcardNumberPhoto2 { get; set; }
        public DateTime? DoB { get; set; }
        public string? Zipcode { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressDistrict { get; set; }
        public string? AddressWard { get; set; }
        public string? AddressDetail { get; set; }
        public bool Active { get; set; }
        public int AccessFailedCount { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTime? LockoutEndDate { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual AccountStatus? AccountStatus { get; set; }
        public virtual AccountType? AccountType { get; set; }
        public virtual Author? Author { get; set; }
        public virtual ICollection<AccountMetum> AccountMeta { get; set; }
        public virtual ICollection<ActivityLog> ActivityLogs { get; set; }
        public virtual ICollection<FavouritePost> FavouritePosts { get; set; }
        public virtual ICollection<Password> Passwords { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<ReadedPost> ReadedPosts { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}

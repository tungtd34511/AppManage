using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.Data.Models
{
    public partial class CRMDevContext : DbContext
    {
        public CRMDevContext()
        {
        }

        public CRMDevContext(DbContextOptions<CRMDevContext> options)
            : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=TUNGHACK\\SQLEXPRESS;Initial Catalog=CRM_Dev1;Integrated Security=True");
        //    }
        //}
        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AccountMetum> AccountMeta { get; set; } = null!;
        public virtual DbSet<AccountStatus> AccountStatuses { get; set; } = null!;
        public virtual DbSet<AccountType> AccountTypes { get; set; } = null!;
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; } = null!;
        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<CommentStatus> CommentStatuses { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerCategory> CustomerCategories { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<FavouritePost> FavouritePosts { get; set; } = null!;
        public virtual DbSet<FeaturedPost> FeaturedPosts { get; set; } = null!;
        public virtual DbSet<FeaturedPostType> FeaturedPostTypes { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderDetailMetum> OrderDetailMeta { get; set; } = null!;
        public virtual DbSet<OrderMetum> OrderMeta { get; set; } = null!;
        public virtual DbSet<OrderPaymentStatus> OrderPaymentStatuses { get; set; } = null!;
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public virtual DbSet<OrderType> OrderTypes { get; set; } = null!;
        public virtual DbSet<Password> Passwords { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<PostCategory> PostCategories { get; set; } = null!;
        public virtual DbSet<PostCommentStatus> PostCommentStatuses { get; set; } = null!;
        public virtual DbSet<PostLayout> PostLayouts { get; set; } = null!;
        public virtual DbSet<PostMetum> PostMeta { get; set; } = null!;
        public virtual DbSet<PostPublishStatus> PostPublishStatuses { get; set; } = null!;
        public virtual DbSet<PostTag> PostTags { get; set; } = null!;
        public virtual DbSet<PostTopic> PostTopics { get; set; } = null!;
        public virtual DbSet<PostType> PostTypes { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductBrand> ProductBrands { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public virtual DbSet<ProductSize> ProductSizes { get; set; } = null!;
        public virtual DbSet<ProductUnit> ProductUnits { get; set; } = null!;
        public virtual DbSet<ProductVariant> ProductVariants { get; set; } = null!;
        public virtual DbSet<ProductVariantGroup> ProductVariantGroups { get; set; } = null!;
        public virtual DbSet<Promotion> Promotions { get; set; } = null!;
        public virtual DbSet<PromotionMetum> PromotionMeta { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<ReadedPost> ReadedPosts { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RolePermission> RolePermissions { get; set; } = null!;
        public virtual DbSet<Shop> Shops { get; set; } = null!;
        public virtual DbSet<ShopMetum> ShopMeta { get; set; } = null!;
        public virtual DbSet<ShopProduct> ShopProducts { get; set; } = null!;
        public virtual DbSet<ShopStatus> ShopStatuses { get; set; } = null!;
        public virtual DbSet<ShopType> ShopTypes { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<Topic> Topics { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<TransactionMetum> TransactionMeta { get; set; } = null!;
        public virtual DbSet<TransactionStatus> TransactionStatuses { get; set; } = null!;
        public virtual DbSet<TransactionType> TransactionTypes { get; set; } = null!;
        public virtual DbSet<Voucher> Vouchers { get; set; } = null!;
        public virtual DbSet<VoucherMetum> VoucherMeta { get; set; } = null!;
        public virtual DbSet<VoucherStatus> VoucherStatuses { get; set; } = null!;
        public virtual DbSet<VoucherType> VoucherTypes { get; set; } = null!;
        public virtual DbSet<Ward> Wards { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;
        public virtual DbSet<WarehouseProduct> WarehouseProducts { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=103.226.250.170;Database=CRM.Dev;UID=CRM.Dev;PWD=7tRH5jAX6yfVX2uqN6eT;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.HasIndex(e => e.AccountStatusId, "IX_Account_AccountStatusId");

                entity.HasIndex(e => e.AccountTypeId, "IX_Account_AccountTypeId");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Fullname).HasMaxLength(255);

                entity.Property(e => e.IdcardNumberPhoto1).HasColumnName("IDCardNumberPhoto1");

                entity.Property(e => e.IdcardNumberPhoto2).HasColumnName("IDCardNumberPhoto2");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.MiddleName).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Username).HasMaxLength(255);

                entity.HasOne(d => d.AccountStatus)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountStatusId);

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountTypeId);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Accounts)
                    .UsingEntity<Dictionary<string, object>>(
                        "AccountRole",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<Account>().WithMany().HasForeignKey("AccountId"),
                        j =>
                        {
                            j.HasKey("AccountId", "RoleId");

                            j.ToTable("AccountRole");

                            j.HasIndex(new[] { "RoleId" }, "IX_AccountRole_RoleId");
                        });
            });

            modelBuilder.Entity<AccountMetum>(entity =>
            {
                entity.HasIndex(e => e.AccountId, "IX_AccountMeta_AccountId");

                entity.Property(e => e.Key).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountMeta)
                    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<AccountStatus>(entity =>
            {
                entity.ToTable("AccountStatus");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.ToTable("AccountType");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.ToTable("ActivityLog");

                entity.HasIndex(e => e.AccountId, "IX_ActivityLog_AccountId");

                entity.Property(e => e.Browser).HasMaxLength(255);

                entity.Property(e => e.Device).HasMaxLength(255);

                entity.Property(e => e.EntityCode).HasMaxLength(255);

                entity.Property(e => e.Info).HasMaxLength(255);

                entity.Property(e => e.IpAddress).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Os)
                    .HasMaxLength(255)
                    .HasColumnName("OS");

                entity.Property(e => e.Url).HasMaxLength(255);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ActivityLogs)
                    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Author");

                entity.HasIndex(e => e.AccountId, "IX_Author_AccountId")
                    .IsUnique();

                entity.Property(e => e.Info).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Photo).HasMaxLength(255);

                entity.HasOne(d => d.Account)
                    .WithOne(p => p.Author)
                    .HasForeignKey<Author>(d => d.AccountId);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.HasIndex(e => e.CommnetStatusId, "IX_Comment_CommnetStatusId");

                entity.HasIndex(e => e.PostId, "IX_Comment_PostId");

                entity.HasOne(d => d.CommnetStatus)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.CommnetStatusId);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId);
            });

            modelBuilder.Entity<CommentStatus>(entity =>
            {
                entity.ToTable("CommentStatus");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryCode).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => e.CustomerCategoryId, "IX_Customer_CustomerCategoryId");

                entity.Property(e => e.Address).HasMaxLength(2048);

                entity.Property(e => e.CitizenId).HasMaxLength(2048);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Email).HasMaxLength(512);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Fullname).HasMaxLength(255);

                entity.Property(e => e.IdcardNumberPhoto1).HasColumnName("IDCardNumberPhoto1");

                entity.Property(e => e.IdcardNumberPhoto2).HasColumnName("IDCardNumberPhoto2");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.MiddleName).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.HasOne(d => d.CustomerCategory)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerCategoryId);
            });

            modelBuilder.Entity<CustomerCategory>(entity =>
            {
                entity.ToTable("CustomerCategory");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.HasIndex(e => e.ProvinceId, "IX_District_ProvinceId");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.ProvinceId);
            });

            modelBuilder.Entity<FavouritePost>(entity =>
            {
                entity.ToTable("FavouritePost");

                entity.HasIndex(e => e.AccountId, "IX_FavouritePost_AccountId");

                entity.HasIndex(e => e.PostId, "IX_FavouritePost_PostId");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.FavouritePosts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.FavouritePosts)
                    .HasForeignKey(d => d.PostId);
            });

            modelBuilder.Entity<FeaturedPost>(entity =>
            {
                entity.ToTable("FeaturedPost");

                entity.HasIndex(e => e.FeaturedPostTypeId, "IX_FeaturedPost_FeaturedPostTypeId");

                entity.HasIndex(e => e.PostId, "IX_FeaturedPost_PostId");

                entity.HasOne(d => d.FeaturedPostType)
                    .WithMany(p => p.FeaturedPosts)
                    .HasForeignKey(d => d.FeaturedPostTypeId);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.FeaturedPosts)
                    .HasForeignKey(d => d.PostId);
            });

            modelBuilder.Entity<FeaturedPostType>(entity =>
            {
                entity.ToTable("FeaturedPostType");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_Orders_CustomerId");

                entity.HasIndex(e => e.OrderPaymentStatusId, "IX_Orders_OrderPaymentStatusId");

                entity.HasIndex(e => e.OrderStatusId, "IX_Orders_OrderStatusId");

                entity.HasIndex(e => e.OrderTypeId, "IX_Orders_OrderTypeId");

                entity.HasIndex(e => e.ShopId, "IX_Orders_ShopId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.OrderPaymentStatus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderPaymentStatusId);

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.OrderType)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderTypeId);

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShopId);

                entity.HasMany(d => d.Promotions)
                    .WithMany(p => p.Orders)
                    .UsingEntity<Dictionary<string, object>>(
                        "OrderPromotion",
                        l => l.HasOne<Promotion>().WithMany().HasForeignKey("PromotionId"),
                        r => r.HasOne<Order>().WithMany().HasForeignKey("OrderId"),
                        j =>
                        {
                            j.HasKey("OrderId", "PromotionId");

                            j.ToTable("OrderPromotion");

                            j.HasIndex(new[] { "PromotionId" }, "IX_OrderPromotion_PromotionId");
                        });
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.HasIndex(e => e.OrderId, "IX_OrderDetail_OrderId");

                entity.HasIndex(e => e.OrderStatusId, "IX_OrderDetail_OrderStatusId");

                entity.HasIndex(e => e.WarehouseProductId, "IX_OrderDetail_WarehouseProductId");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderStatusId);

                entity.HasOne(d => d.WarehouseProduct)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.WarehouseProductId);
            });

            modelBuilder.Entity<OrderDetailMetum>(entity =>
            {
                entity.HasIndex(e => e.OrderDetailId, "IX_OrderDetailMeta_OrderDetailId");

                entity.Property(e => e.Key).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.OrderDetailMeta)
                    .HasForeignKey(d => d.OrderDetailId);
            });

            modelBuilder.Entity<OrderMetum>(entity =>
            {
                entity.HasIndex(e => e.OrderId, "IX_OrderMeta_OrderId");

                entity.Property(e => e.Key).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderMeta)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<OrderPaymentStatus>(entity =>
            {
                entity.ToTable("OrderPaymentStatus");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus");
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.ToTable("OrderType");
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.ToTable("Password");

                entity.HasIndex(e => e.AccountId, "IX_Password_AccountId");

                entity.Property(e => e.OldPassword).HasMaxLength(255);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Passwords)
                    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.HasIndex(e => e.AuthorId, "IX_Post_AuthorId");

                entity.HasIndex(e => e.PostCategoryId, "IX_Post_PostCategoryId");

                entity.HasIndex(e => e.PostCommentStatusId, "IX_Post_PostCommentStatusId");

                entity.HasIndex(e => e.PostLayoutId, "IX_Post_PostLayoutId");

                entity.HasIndex(e => e.PostPublishStatusId, "IX_Post_PostPublishStatusId");

                entity.HasIndex(e => e.PostTypeId, "IX_Post_PostTypeId");

                entity.HasIndex(e => e.UserId, "IX_Post_UserId");

                entity.Property(e => e.GuId).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Name2).HasMaxLength(255);

                entity.Property(e => e.Photo).HasMaxLength(255);

                entity.Property(e => e.Url).HasMaxLength(255);

                entity.Property(e => e.Url2).HasMaxLength(255);

                entity.Property(e => e.Video).HasMaxLength(255);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.AuthorId);

                entity.HasOne(d => d.PostCategory)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostCategoryId);

                entity.HasOne(d => d.PostCommentStatus)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostCommentStatusId);

                entity.HasOne(d => d.PostLayout)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostLayoutId);

                entity.HasOne(d => d.PostPublishStatus)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostPublishStatusId);

                entity.HasOne(d => d.PostType)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostTypeId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<PostCategory>(entity =>
            {
                entity.ToTable("PostCategory");

                entity.HasIndex(e => e.ParentId, "IX_PostCategory_ParentId");

                entity.Property(e => e.Color).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Name2).HasMaxLength(255);

                entity.Property(e => e.Photo).HasMaxLength(255);

                entity.Property(e => e.Slug).HasMaxLength(255);

                entity.Property(e => e.Slug2).HasMaxLength(255);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<PostCommentStatus>(entity =>
            {
                entity.ToTable("PostCommentStatus");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<PostLayout>(entity =>
            {
                entity.ToTable("PostLayout");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<PostMetum>(entity =>
            {
                entity.HasIndex(e => e.PostId, "IX_PostMeta_PostId");

                entity.Property(e => e.Key).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostMeta)
                    .HasForeignKey(d => d.PostId);
            });

            modelBuilder.Entity<PostPublishStatus>(entity =>
            {
                entity.ToTable("PostPublishStatus");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<PostTag>(entity =>
            {
                entity.ToTable("PostTag");

                entity.HasIndex(e => e.PostId, "IX_PostTag_PostId");

                entity.HasIndex(e => e.TagId, "IX_PostTag_TagId");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostTags)
                    .HasForeignKey(d => d.PostId);

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.PostTags)
                    .HasForeignKey(d => d.TagId);
            });

            modelBuilder.Entity<PostTopic>(entity =>
            {
                entity.ToTable("PostTopic");

                entity.HasIndex(e => e.PostId, "IX_PostTopic_PostId");

                entity.HasIndex(e => e.TopicId, "IX_PostTopic_TopicId");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostTopics)
                    .HasForeignKey(d => d.PostId);

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.PostTopics)
                    .HasForeignKey(d => d.TopicId);
            });

            modelBuilder.Entity<PostType>(entity =>
            {
                entity.ToTable("PostType");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => e.ProductBrandId, "IX_Product_ProductBrandId");

                entity.HasIndex(e => e.ProductCategoryId, "IX_Product_ProductCategoryId");

                entity.HasIndex(e => e.ProductUnitId, "IX_Product_ProductUnitId");

                entity.HasOne(d => d.ProductBrand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductBrandId);

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCategoryId);

                entity.HasOne(d => d.ProductUnit)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductUnitId);
            });

            modelBuilder.Entity<ProductBrand>(entity =>
            {
                entity.ToTable("ProductBrand");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");

                entity.HasIndex(e => e.ParentId, "IX_ProductCategory_ParentId");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<ProductSize>(entity =>
            {
                entity.ToTable("ProductSize");
            });

            modelBuilder.Entity<ProductUnit>(entity =>
            {
                entity.ToTable("ProductUnit");
            });

            modelBuilder.Entity<ProductVariant>(entity =>
            {
                entity.ToTable("ProductVariant");

                entity.HasIndex(e => e.ProductVariantGroupId, "IX_ProductVariant_ProductVariantGroupId");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.ProductVariantGroup)
                    .WithMany(p => p.ProductVariants)
                    .HasForeignKey(d => d.ProductVariantGroupId);
            });

            modelBuilder.Entity<ProductVariantGroup>(entity =>
            {
                entity.ToTable("ProductVariantGroup");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.ToTable("Promotion");
            });

            modelBuilder.Entity<PromotionMetum>(entity =>
            {
                entity.HasIndex(e => e.PromotionId, "IX_PromotionMeta_PromotionId");

                entity.Property(e => e.Key).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.PromotionMeta)
                    .HasForeignKey(d => d.PromotionId);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.HasIndex(e => e.CountryId, "IX_Province_CountryId");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<ReadedPost>(entity =>
            {
                entity.ToTable("ReadedPost");

                entity.HasIndex(e => e.AccountId, "IX_ReadedPost_AccountId");

                entity.HasIndex(e => e.PostId, "IX_ReadedPost_PostId");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ReadedPosts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.ReadedPosts)
                    .HasForeignKey(d => d.PostId);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.HasKey(e => new { e.PermissionCode, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_RolePermissions_RoleId");

                entity.Property(e => e.PermissionCode).HasMaxLength(512);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.ToTable("Shop");

                entity.HasIndex(e => e.ShopStatusId, "IX_Shop_ShopStatusId");

                entity.HasIndex(e => e.ShopTypeId, "IX_Shop_ShopTypeId");

                entity.HasIndex(e => e.UserId, "IX_Shop_UserId");

                entity.Property(e => e.ContactPerson).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Photo).HasMaxLength(255);

                entity.HasOne(d => d.ShopStatus)
                    .WithMany(p => p.Shops)
                    .HasForeignKey(d => d.ShopStatusId);

                entity.HasOne(d => d.ShopType)
                    .WithMany(p => p.Shops)
                    .HasForeignKey(d => d.ShopTypeId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Shops)
                    .HasForeignKey(d => d.UserId);

                entity.HasMany(d => d.WareHouses)
                    .WithMany(p => p.Shops)
                    .UsingEntity<Dictionary<string, object>>(
                        "WarehouseShop",
                        l => l.HasOne<Warehouse>().WithMany().HasForeignKey("WareHouseId"),
                        r => r.HasOne<Shop>().WithMany().HasForeignKey("ShopId"),
                        j =>
                        {
                            j.HasKey("ShopId", "WareHouseId");

                            j.ToTable("WarehouseShop");

                            j.HasIndex(new[] { "WareHouseId" }, "IX_WarehouseShop_WareHouseId");
                        });
            });

            modelBuilder.Entity<ShopMetum>(entity =>
            {
                entity.HasIndex(e => e.ShopId, "IX_ShopMeta_ShopId");

                entity.Property(e => e.Key).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ShopMeta)
                    .HasForeignKey(d => d.ShopId);
            });

            modelBuilder.Entity<ShopProduct>(entity =>
            {
                entity.HasKey(e => new { e.ShopId, e.ProductId });

                entity.ToTable("ShopProduct");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ShopProducts)
                    .HasForeignKey(d => d.ShopId);

                entity.HasOne(d => d.ShopNavigation)
                    .WithMany(p => p.ShopProducts)
                    .HasForeignKey(d => d.ShopId);
            });

            modelBuilder.Entity<ShopStatus>(entity =>
            {
                entity.ToTable("ShopStatus");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ShopType>(entity =>
            {
                entity.ToTable("ShopType");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.Property(e => e.Color).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Name2).HasMaxLength(255);

                entity.Property(e => e.Slug).HasMaxLength(255);

                entity.Property(e => e.Slug2).HasMaxLength(255);
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");

                entity.Property(e => e.Color).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Name2).HasMaxLength(255);

                entity.Property(e => e.Photo).HasMaxLength(255);

                entity.Property(e => e.Slug).HasMaxLength(255);

                entity.Property(e => e.Slug2).HasMaxLength(255);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasIndex(e => e.OrderId, "IX_Transactions_OrderId");

                entity.HasIndex(e => e.TransactionStatusId, "IX_Transactions_TransactionStatusId");

                entity.HasIndex(e => e.TransactionTypeId, "IX_Transactions_TransactionTypeId");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.TransactionStatus)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TransactionStatusId);

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TransactionTypeId);
            });

            modelBuilder.Entity<TransactionMetum>(entity =>
            {
                entity.HasIndex(e => e.TransactionId, "IX_TransactionMeta_TransactionId");

                entity.Property(e => e.Key).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.TransactionMeta)
                    .HasForeignKey(d => d.TransactionId);
            });

            modelBuilder.Entity<TransactionStatus>(entity =>
            {
                entity.ToTable("TransactionStatus");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("TransactionType");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.ToTable("Voucher");

                entity.HasIndex(e => e.PromotionId, "IX_Voucher_PromotionId");

                entity.HasIndex(e => e.VoucherStatusId, "IX_Voucher_VoucherStatusId");

                entity.HasIndex(e => e.VoucherTypeId, "IX_Voucher_VoucherTypeId");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.PromotionId);

                entity.HasOne(d => d.VoucherStatus)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.VoucherStatusId);

                entity.HasOne(d => d.VoucherType)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.VoucherTypeId);
            });

            modelBuilder.Entity<VoucherMetum>(entity =>
            {
                entity.HasIndex(e => e.VoucherId, "IX_VoucherMeta_VoucherId");

                entity.Property(e => e.Key).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.VoucherMeta)
                    .HasForeignKey(d => d.VoucherId);
            });

            modelBuilder.Entity<VoucherStatus>(entity =>
            {
                entity.ToTable("VoucherStatus");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<VoucherType>(entity =>
            {
                entity.ToTable("VoucherType");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.ToTable("Ward");

                entity.HasIndex(e => e.DistrictId, "IX_Ward_DistrictId");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Wards)
                    .HasForeignKey(d => d.DistrictId);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("Warehouse");
            });

            modelBuilder.Entity<WarehouseProduct>(entity =>
            {
                entity.ToTable("WarehouseProduct");

                entity.HasIndex(e => e.ProductId, "IX_WarehouseProduct_ProductId");

                entity.HasIndex(e => e.ProductSizeId, "IX_WarehouseProduct_ProductSizeId");

                entity.HasIndex(e => e.WareHouseId, "IX_WarehouseProduct_WareHouseId");

                entity.Property(e => e.ProductVarientIds).HasMaxLength(255);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WarehouseProducts)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.ProductSize)
                    .WithMany(p => p.WarehouseProducts)
                    .HasForeignKey(d => d.ProductSizeId);

                entity.HasOne(d => d.WareHouse)
                    .WithMany(p => p.WarehouseProducts)
                    .HasForeignKey(d => d.WareHouseId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.DbContext
{
    public class EcoDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-PN0T4CFM\SQLEXPRESS; Database = EcoDb; Trusted_Connection=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
    }
}

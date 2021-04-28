using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Product :IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductKey { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public bool StockStatus { get; set; }
        public virtual Model Model { get; set; }
        public int ModelId { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public int SubcategoryId { get; set; }
        public virtual List<ProductPhoto> ProductPhotos { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<CartDetail> CartDetails { get; set; }
        public virtual List<Wishlist> Wishlists { get; set; }
    }
}

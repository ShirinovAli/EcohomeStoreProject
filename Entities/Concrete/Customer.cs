using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer :IEntity
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte [] PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Cart> Carts { get; set; }
        public virtual List<Wishlist> Wishlists { get; set; }
    }
}

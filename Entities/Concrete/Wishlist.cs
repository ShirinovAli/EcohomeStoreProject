using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Wishlist :IEntity
    {
        public int Id { get; set; }
        public DateTime AdditionalDate { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}

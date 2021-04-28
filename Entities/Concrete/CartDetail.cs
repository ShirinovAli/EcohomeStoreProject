using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class CartDetail :IEntity
    {
        public int Id { get; set; }
        public virtual Cart Cart { get; set; }
        public int CartId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
